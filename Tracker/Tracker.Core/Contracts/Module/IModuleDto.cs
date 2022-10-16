using Tracker.Core.Enums;
using Wolf.Utility.Core.Persistence.Core;

namespace Tracker.Core.Contracts.Module
{
    public interface IModuleDto : IDto
    {
        int OwnerId { get; set; }
        ModuleType ModuleType { get; set; }
    }
}