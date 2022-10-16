namespace Tracker.Module.Settings.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            var startup = new SettingsStartup(builder.Configuration);

            startup.ConfigureServices(builder.Services);
            WebApplication app = builder.Build();
            startup.Configure(app, app.Environment);

            app.Run();
        }
    }
}