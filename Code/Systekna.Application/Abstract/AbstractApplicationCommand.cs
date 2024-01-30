using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands
{
    public abstract class AbstractApplicationCommand(IDbRepositoryCommand db) 
        : IApplicationCommand
    {
        private readonly IDbRepositoryCommand _db = db;
        public virtual IEnumerable<EntityCommand> GetAll(EntityCommand entity) 
            => _db.GetAll(entity);
    }
}