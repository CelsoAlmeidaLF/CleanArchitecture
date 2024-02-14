using Systekna.Core.Entity;

namespace Systekna.Application.Querys.Interface
{
    internal interface IConsultaQuery<TEntity> where TEntity : EntityCommand, new()
    {
        List<TEntity> Execute();
    }
}