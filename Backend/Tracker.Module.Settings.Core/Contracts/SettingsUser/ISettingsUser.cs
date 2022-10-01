using Tracker.Core.Contracts.User;

namespace Tracker.Module.Settings.Core.Contracts.SettingsUser
{
    public interface ISettingsUser : IUser, ISearchableSettingsUser
    {
        new ISettingsUser UnpackDto<TDto>(TDto dto) where TDto : class, ISettingsUserDto;
       
    }
}