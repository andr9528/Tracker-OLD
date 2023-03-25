using Tracker.Core.Contracts.Module;
using Tracker.Core.Contracts.User;
using Tracker.Core.Enums;

namespace Tracker.Core.Models.User
{
    public class User : IUser
    {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public byte[] Version { get; set; }

        /// <inheritdoc />
        public DateTime CreatedDate { get; set; }

        /// <inheritdoc />
        public DateTime UpdatedDate { get; set; }

        /// <inheritdoc />
        public string ExternalId { get; set; }

        /// <inheritdoc />
        public UserType UserType { get; set; }

        /// <inheritdoc />
        public ICollection<IModule> Modules { get; set; }

        /// <inheritdoc />
        public static IUser UnpackDto<TDto>(TDto dto) where TDto : class, IUserDto
        {
            var output = new User();
            output.UserType = dto.UserType;
            output.ExternalId = dto.ExternalId;
            return output;
        }
    }
}