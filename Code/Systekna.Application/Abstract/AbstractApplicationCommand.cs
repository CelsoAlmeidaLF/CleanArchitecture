using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands;

public abstract class AbstractApplicationCommand<Entity>(IDbRepositoryCommand<Entity> db) 
    : IApplicationCommand<Entity> where Entity : EntityCommand ,new()
{
    private readonly IDbRepositoryCommand<Entity> _db = db;
    public virtual IEnumerable<Entity> GetAll(Entity entity) 
        => _db.GetAll(entity);
}