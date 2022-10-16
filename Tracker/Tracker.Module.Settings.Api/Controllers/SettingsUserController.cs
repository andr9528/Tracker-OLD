using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracker.Module.Settings.Models.SettingsUser;
using Wolf.Utility.Core.Logging;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace Tracker.Module.Settings.Api.Controllers
{
    [Route("api/Settings/[controller]")]
    [ApiController]
    public class SettingsUserController : ControllerBase
    {
        public SettingsUserController(IHandler<SettingsUser, SearchableSettingsUser> handler, ILoggerManager logger)
        {
            logger.SetCaller(nameof(SettingsUserController));
        }
    }
}
