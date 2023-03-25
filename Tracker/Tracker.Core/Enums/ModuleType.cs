using Wolf.Utility.Core.Extensions.Classes;

namespace Tracker.Core.Enums
{
    public class ModuleType : Enumeration
    {
        public const string UNKNOWN = "Unknown";
        public const string SETTINGS = "Settings";
        public const string BUDGET = "Budget";
        public const string TIME = "Time";
        public const string DINING = "Dining";
        public const string COMMAND_CHAIN = "CommandChain";

        public static readonly ModuleType Unknown = new(0, UNKNOWN);
        public static readonly ModuleType Settings = new(1, SETTINGS);
        public static readonly ModuleType Budget = new(2, BUDGET);
        public static readonly ModuleType Time = new(3, TIME);
        public static readonly ModuleType Dining = new(4, DINING);
        public static readonly ModuleType CommandChain = new(5, COMMAND_CHAIN);

        /// <inheritdoc />
        protected ModuleType(int id, string name) : base(id, name)
        {

        }
    }
}