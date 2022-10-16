using Tracker.Core.Contracts.Module;
using Tracker.Core.Contracts.User;
using Tracker.Core.Enums;

namespace Tracker.Core.Models.User
{
    public abstract class User : IUser
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
        public virtual IUser UnpackDto<TDto>(TDto dto) where TDto : class, IUserDto
        {
            UserType = dto.UserType;
            ExternalId = dto.ExternalId;
            return this;
        }
    }
}