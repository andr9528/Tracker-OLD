using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracker.Core.Persistence.Config;
using Tracker.Module.Settings.Models.SettingsUser;

namespace Tracker.Module.Settings.Persistence.Config
{
    public class SettingsUserConfig : UserConfig<SettingsUser>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<SettingsUser> builder)
        {
            base.Configure(builder);
        }
    }
}