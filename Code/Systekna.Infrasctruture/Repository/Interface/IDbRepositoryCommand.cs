using Systekna.Core;
using Systekna.Core.Entity.Base;

namespace Systekna.Infrasctruture.Repository
{
    public interface IDbRepositoryCommand<Entity> : IRepository<Entity> where Entity : EntityBase, new()
    {
    }
}