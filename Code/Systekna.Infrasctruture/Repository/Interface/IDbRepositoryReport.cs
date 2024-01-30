using Systekna.Core;

namespace Systekna.Infrasctruture
{
    public interface IDbRepositoryReport
    {
        public IEnumerable<EntityAnalyticalReport> GetAllAnalyticalReport(EntityAnalyticalReport entity);
        public IEnumerable<EntitySystematicReport> GetAllSystematicReport(EntitySystematicReport entity);
        public IEnumerable<EntityInconsistencyReport> GetAllInconsistencyReport(EntityInconsistencyReport entity);
    }
}