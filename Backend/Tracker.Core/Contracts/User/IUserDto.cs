using Tracker.Core.Enums;

namespace Tracker.Core.Contracts.User
{
    public interface IUserDto
    {
        string ExternalId { get; set; }
        UserType UserType { get; set; }
    }
}