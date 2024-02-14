using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository.Interface.Base;

namespace Systekna.Application.Querys.Interface
{
    internal interface IConsultaQuery<TRepository, TEntity> 
        where TEntity : EntityCommand, new()
        where TRepository : IRepository<TEntity>
    {
        TRepository DbRepository { get; }
        List<TEntity> Execute();
    }
}