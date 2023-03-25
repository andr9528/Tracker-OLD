using Tracker.Core.Contracts.Module;
using Wolf.Utility.Core.Persistence.Core;

namespace Tracker.Core.Contracts.User
{
    public interface IUser : IEntity, ISearchableUser
    {
        /// <summary>
        /// Modules that the current user has currently or previously activated.
        /// </summary>
        ICollection<IModule> Modules { get; set; }
        /// <summary>
        /// Unpacks the given Dto into the current object.
        /// </summary>
        /// <typeparam name="TDto"></typeparam>
        /// <param name="dto"></param>
        /// <returns>Returns the current object, that was unpacked into</returns>
        static IUser UnpackDto<TDto>(TDto dto) where TDto : class, IUserDto => throw new NotImplementedException();
    }
}