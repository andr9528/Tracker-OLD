using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracker.Core.Models.User;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace Tracker.Core.Persistence.Config
{
    public class UserConfig<TUser> : EntityConfig<TUser> where TUser : User
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<TUser> builder)
        {
            base.Configure(builder);

            builder.HasMany(x => x.Modules).WithOne(x => (TUser) x.Owner).HasForeignKey(x => x.OwnerId);
        }
    }
}