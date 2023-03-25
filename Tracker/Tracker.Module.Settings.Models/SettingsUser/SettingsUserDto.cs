using Tracker.Core.Contracts.User;
using Tracker.Core.Models.User;
using Tracker.Module.Settings.Core.Contracts.SettingsUser;

namespace Tracker.Module.Settings.Models.SettingsUser
{
    public class SettingsUserDto : ISettingsUserDto
    {
        public SettingsUserDto()
        {
            
        }

        /// <inheritdoc />
        public IUserDto UserDto { get; set; }
    }
}