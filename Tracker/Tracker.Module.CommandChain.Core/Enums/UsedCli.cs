using Wolf.Utility.Core.Extensions.Classes;

namespace Tracker.Module.CommandChain.Core.Enums
{
    public class UsedCli : Enumeration
    {
        public const string POWER_SHELL = "PowerShell";
        public const string TERMINAL = "Terminal";
        public const string CMD = "PowerShell";

        public static readonly UsedCli PowerShell = new (0, POWER_SHELL);
        public static readonly UsedCli Terminal = new(1, TERMINAL);
        public static readonly UsedCli Cmd = new(2, CMD);

        /// <inheritdoc />
        protected UsedCli(int id, string name) : base(id, name)
        {
        }
    }
}