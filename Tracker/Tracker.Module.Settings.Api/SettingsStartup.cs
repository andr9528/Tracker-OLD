using Microsoft.EntityFrameworkCore;
using Tracker.Module.Settings.Models.SettingsUser;
using Tracker.Module.Settings.Persistence;
using Tracker.Module.Settings.Persistence.Handlers;
using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Persistence.EntityFramework;
using Wolf.Utility.Core.Startup;
using Wolf.Utility.Core.Startup.Modules;

namespace Tracker.Module.Settings.Api
{
    public class SettingsStartup : ModularStartup, IStartupModule
    {
        private const string DATABASE_CONNECTION_STRING_NAME = "mainDb";
        public SettingsStartup(IConfiguration configuration) : base(configuration)
        {
            AddModule(new NLogStartupModule());
            AddModule(new SwaggerStartupModule());
            AddModule(
                new EntityFrameworkStartupModule<SettingsContext, SettingsUserHandler, SettingsUser,
                    SearchableSettingsUser>(options =>
                    options.UseSqlite(Configuration.GetConnectionString(DATABASE_CONNECTION_STRING_NAME))));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            base.SetupServices(services);

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            SetupApplication(app);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }

        /// <inheritdoc />
        public void SetupServices(IServiceCollection services)
        {
            ConfigureServices(services);
        }

        /// <inheritdoc />
        public void ConfigureApplication(IApplicationBuilder app)
        {
            var env = ((WebApplication) app).Environment;

            Configure(app, env);
        }
    }
}