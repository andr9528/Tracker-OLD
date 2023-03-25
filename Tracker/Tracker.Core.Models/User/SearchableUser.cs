using Tracker.Core.Contracts.User;
using Tracker.Core.Enums;

namespace Tracker.Core.Models.User
{
    public abstract class SearchableUser : ISearchableUser
    {
        /// <inheritdoc />
        public int Id { get; set; }

        /// <inheritdoc />
        public IUserDto UserDto { get; set; }
    }
}