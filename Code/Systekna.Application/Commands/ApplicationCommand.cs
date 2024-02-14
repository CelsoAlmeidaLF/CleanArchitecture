using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands
{
    public class ApplicationCommand<Entity>(IDbRepositoryCommand<Entity> db) 
        : AbstractApplicationCommand<Entity>(db),  IApplicationCommand<Entity> where Entity : EntityCommand, new()
    {
        public IDbRepositoryCommand<Entity> _db = db;
        public override IEnumerable<Entity> GetAll(Entity entity) => _db.GetAll(entity);
    }
}