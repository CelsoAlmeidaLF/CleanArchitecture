using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands;

public abstract class AbstractApplicationCommand<Entity>(IDbRepositoryCommand<Entity> db) 
    : IApplicationCommand<Entity> where Entity : EntityCommand ,new()
{
    public virtual IEnumerable<Entity> GetAll(Entity entity) => db.GetAll(entity);
}