using Tracker.Core.Contracts.User;

namespace Tracker.Module.CommandChain.Core.Contracts.CommandChainUser
{
    public interface ICommandChainUser: IUserBase, ISearchableCommandChainUser
    {
        new ICommandChainUser UnpackDto<TDto>(TDto dto) where TDto : class, ICommandChainUserDto;
    }
}