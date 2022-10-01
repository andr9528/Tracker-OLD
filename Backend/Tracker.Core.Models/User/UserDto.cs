using Tracker.Core.Contracts.User;
using Tracker.Core.Enums;

namespace Tracker.Core.Models.User
{
    public abstract class UserDto : IUserDto
    {
        /// <inheritdoc />
        public string ExternalId { get; set; }

        /// <inheritdoc />
        public UserType UserType { get; set; }
    }
}