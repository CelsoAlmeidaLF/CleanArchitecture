using Microsoft.EntityFrameworkCore;
using Systekna.Core;

namespace Systekna.Infrasctruture
{
    public class DbRepositoryReport : DbContext, IDbRepositoryReport
    {
        #region ...

        public DbRepositoryReport(DbContextOptions options) : base(options)
        {          
        }

        private readonly DbSet<EntityAnalyticalReport>? _analyticals;
        private readonly DbSet<EntitySystematicReport>? _systematics;
        private readonly DbSet<EntityInconsistencyReport>? _inconsistencies;

        #endregion

        public IEnumerable<EntityAnalyticalReport> GetAllAnalyticalReport(EntityAnalyticalReport entity)
            => _analyticals != null ? _analyticals.ToList() : new List<EntityAnalyticalReport>();

        public IEnumerable<EntitySystematicReport> GetAllSystematicReport(EntitySystematicReport entity)
            => _systematics != null ? _systematics.ToList() : new List<EntitySystematicReport>();

        public IEnumerable<EntityInconsistencyReport> GetAllInconsistencyReport(EntityInconsistencyReport entity)
            => _inconsistencies != null ? _inconsistencies.ToList() : new List<EntityInconsistencyReport>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => base.OnConfiguring(optionsBuilder);
    }
}