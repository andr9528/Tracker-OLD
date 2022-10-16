using Tracker.Core.Contracts.Module;
using Tracker.Core.Enums;

namespace Tracker.Core.Models.Module
{
    public class ModuleDto : IModuleDto
    {
        /// <inheritdoc />
        public int OwnerId { get; set; }

        /// <inheritdoc />
        public ModuleType ModuleType { get; set; }
    }
}