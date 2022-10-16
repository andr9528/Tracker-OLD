using Microsoft.EntityFrameworkCore;

using System.Diagnostics.CodeAnalysis;
using Tracker.Module.Settings.Models.SettingsUser;
using Tracker.Module.Settings.Persistence.Config;
using Wolf.Utility.Core.Persistence.EntityFramework;

namespace Tracker.Module.Settings.Persistence
{
    public class SettingsContext : BaseContext
    {
        public SettingsContext()
        {
        }

        public SettingsContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<SettingsUser> Users { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new SettingsUserConfig());
        }
    }
}