using Tracker.Core.Contracts.Module;
using Tracker.Core.Contracts.User;
using Tracker.Core.Enums;

namespace Tracker.Core.Models.Module
{
    public class Module : IModule
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
        public int OwnerId { get; set; }

        /// <inheritdoc />
        public ModuleType ModuleType { get; set; }

        /// <inheritdoc />
        public IUser Owner { get; set; }

        /// <inheritdoc />
        public bool IsActive { get; set; }

        /// <inheritdoc />
        public IModule UnpackDto<TDto>(TDto dto) where TDto : class, IModuleDto
        {
            OwnerId = dto.OwnerId;
            ModuleType = dto.ModuleType;
            return this;
        }
    }
}