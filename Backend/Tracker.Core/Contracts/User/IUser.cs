using Wolf.Utility.Core.Persistence.Core;

namespace Tracker.Core.Contracts.User
{
    public interface IUser : IEntity, ISearchableUser
    {
        /// <summary>
        /// Unpacks the given Dto into the current object.
        /// </summary>
        /// <typeparam name="TDto"></typeparam>
        /// <param name="dto"></param>
        /// <returns>Returns the current object, that was unpacked into</returns>
        IUser UnpackDto<TDto>(TDto dto) where TDto : class, IUserDto;
    }
}