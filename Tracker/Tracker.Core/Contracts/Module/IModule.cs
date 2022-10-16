using Tracker.Core.Contracts.User;
using Wolf.Utility.Core.Persistence.Core;

namespace Tracker.Core.Contracts.Module
{
    public interface IModule : IEntity, ISearchableModule
    {
        IUser Owner { get; set; }
        bool IsActive { get; set; }

        /// <summary>
        /// Unpacks the given Dto into the current object.
        /// </summary>
        /// <typeparam name="TDto"></typeparam>
        /// <param name="dto"></param>
        /// <returns>Returns the current object, that was unpacked into</returns>
        IModule UnpackDto<TDto>(TDto dto) where TDto : class, IModuleDto;
    }
}