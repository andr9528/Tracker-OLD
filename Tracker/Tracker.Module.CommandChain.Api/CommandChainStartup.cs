using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Startup;
using Wolf.Utility.Core.Startup.Modules;

namespace Tracker.Module.CommandChain.Api
{
    public class CommandChainStartup : ModularStartup, IStartupModule
    {
        private const string DATABASE_CONNECTION_STRING_NAME = "mainDb";

        public CommandChainStartup()
        {
            AddModule(new NLogStartupModule());
            AddModule(new SwaggerStartupModule());
        }

        /// <inheritdoc />
        public void ConfigureServices(IServiceCollection services)
        {
            SetupServices(services);
            services.AddControllers();
        }

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
        public void ConfigureApplication(IApplicationBuilder app)
        {
            var env = ((WebApplication) app).Environment;

            Configure(app, env);
        }
    }
}