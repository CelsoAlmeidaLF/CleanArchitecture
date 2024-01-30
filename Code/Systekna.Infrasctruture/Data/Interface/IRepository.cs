using Systekna.Core.Entity;

namespace Systekna.Infrasctruture
{
    public interface IRepository
    {
        /// <summary>
        /// Consulta lista no banco de dados.
        /// </summary>
        IEnumerable<EntityCommand> GetAll(EntityCommand entityCommand);
    }
}