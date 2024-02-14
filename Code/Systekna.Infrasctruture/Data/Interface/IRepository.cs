using Systekna.Core.Entity;
using Systekna.Core.Entity.Base;

namespace Systekna.Infrasctruture
{
    public interface IRepository<Entity> where Entity : EntityBase, new()
    {
        IEnumerable<Entity> GetAll(Entity entity);
    }
}