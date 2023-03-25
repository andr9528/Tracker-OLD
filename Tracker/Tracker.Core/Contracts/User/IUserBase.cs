namespace Tracker.Core.Contracts.User
{
    public interface IUserBase
    {
        IUser BaseUser { get; set; }
        int BaseUserId { get; set; }
    }
}