using Tracker.Core.Enums;
using Wolf.Utility.Core.Persistence.Core;

namespace Tracker.Core.Contracts.User
{
    public interface IUserDto : IDto
    {
        string ExternalId { get; set; }
        UserType UserType { get; set; }
    }
}