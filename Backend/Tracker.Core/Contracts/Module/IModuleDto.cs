using Tracker.Core.Enums;

namespace Tracker.Core.Contracts.Module
{
    public interface IModuleDto
    {
        int OwnerId { get; set; }
        ModuleType ModuleType { get; set; }
    }
}