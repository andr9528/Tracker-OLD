using Tracker.Module.CommandChain.Core.Enums;

namespace Tracker.Module.CommandChain.Core.Contracts.CommandChain
{
    public interface ISearchableCommandChain
    {
        UsedCli UsedCli { get; set; }
    }
}