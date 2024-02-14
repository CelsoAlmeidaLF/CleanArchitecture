using Systekna.Core.Entity.Base;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands
{
    public interface IApplicationCommand<Entity> : IDbRepositoryCommand<Entity> where Entity : EntityBase, new()
    {
    }
}