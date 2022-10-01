using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Startup;
using Wolf.Utility.Core.Startup.Modules;

namespace Tracker.Api;

public class Startup : ModularStartup
{
    public Startup(IConfiguration configuration) : base(configuration)
    {
        AddModule(new NLogStartupModule());
        AddModule(new SwaggerStartupModule());
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        SetupServices(services);

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

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}