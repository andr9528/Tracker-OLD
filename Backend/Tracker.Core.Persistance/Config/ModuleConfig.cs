using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracker.Core.Models.Module;
using Wolf.Utility.Core.Persistence.EntityFramework.Core;

namespace Tracker.Core.Persistence.Config
{
    public class ModuleConfig : EntityConfig<Module>
    {
        /// <inheritdoc />
        public override void Configure(EntityTypeBuilder<Module> builder)
        {
            base.Configure(builder);
        }
    }
}