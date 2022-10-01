using Tracker.Core.Models.User;
using Tracker.Module.Settings.Core.Contracts.SettingsUser;

namespace Tracker.Module.Settings.Models.SettingsUser
{
    public class SettingsUser : User, ISettingsUser
    {
        /// <inheritdoc />
        public new ISettingsUser UnpackDto<TDto>(TDto dto) where TDto : class, ISettingsUserDto
        {
            base.UnpackDto(dto);
            return this;
        }
    }
}