using Wolf.Utility.Core.Extensions.Classes;

namespace Tracker.Core.Enums
{
    public class UserType : Enumeration
    {
        public const string UNKNOWN = "Unknown";
        public const string GOOGLE = "Google";
        public const string MICROSOFT = "Microsoft";

        public static readonly UserType Unknown = new(0, UNKNOWN);
        public static readonly UserType Google = new(1, GOOGLE);
        public static readonly UserType Microsoft = new(2, MICROSOFT);

        /// <inheritdoc />
        protected UserType(int id, string name) : base(id, name)
        {

        }
    }
}