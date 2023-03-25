using Tracker.Core.Contracts.User;
using Tracker.Core.Models.User;
using Tracker.Module.Settings.Core.Contracts.SettingsUser;

namespace Tracker.Module.Settings.Models.SettingsUser
{
    public class SettingsUser : ISettingsUser
    {
        /// <inheritdoc />
        public static ISettingsUser UnpackDto<TDto>(TDto dto) where TDto : class, ISettingsUserDto
        {
            var output = new SettingsUser
            {
                BaseUser = User.UnpackDto(dto.UserDto),
            };
            return output;
        }

        /// <inheritdoc />
        public IUser BaseUser { get; set; }

        /// <inheritdoc />
        public int BaseUserId { get; set; }
    }
}