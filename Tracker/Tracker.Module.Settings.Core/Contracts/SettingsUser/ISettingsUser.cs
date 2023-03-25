using Tracker.Core.Contracts.User;

namespace Tracker.Module.Settings.Core.Contracts.SettingsUser
{
    public interface ISettingsUser : IUserBase, ISearchableSettingsUser
    {
        static ISettingsUser UnpackDto<TDto>(TDto dto) where TDto : class, ISettingsUserDto => throw new NotImplementedException();

    }
}