using Tracker.Core.Contracts.Module;
using Tracker.Core.Enums;

namespace Tracker.Core.Models.Module
{
    public class SearchableModule : ISearchableModule
    {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public int OwnerId { get; set; }

        /// <inheritdoc />
        public ModuleType ModuleType { get; set; }
    }
}