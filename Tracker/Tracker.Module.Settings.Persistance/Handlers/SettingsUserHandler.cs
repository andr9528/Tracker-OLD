using Tracker.Module.Settings.Models.SettingsUser;
using Wolf.Utility.Core.Persistence.EntityFramework;

namespace Tracker.Module.Settings.Persistence.Handlers
{
    public class SettingsUserHandler : BaseHandler<SettingsContext, SettingsUser, SearchableSettingsUser>
    {
        /// <inheritdoc />
        public SettingsUserHandler(SettingsContext context) : base(context)
        {
        }

        /// <inheritdoc />
        protected override IQueryable<SettingsUser> GetQueryable()
        {
            return Context.Users.AsQueryable();
        }

        /// <inheritdoc />
        protected override IQueryable<SettingsUser> BuildFindQuery(SearchableSettingsUser search)
        {
            var query = base.BuildFindQuery(search);

            if (!string.IsNullOrWhiteSpace(search.ExternalId))
                query = query.Where(x => x.ExternalId.Contains(search.ExternalId));
            if (search.UserType != default)
                query = query.Where(x => x.UserType.Equals(search.UserType));

            return query;
        }
    }
}