using Systekna.Application.Querys.Interface;
using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;
using Systekna.Querys.Base;

namespace Systekna.Querys
{
    namespace Base
    {
        internal abstract class ConsultaApplicationQueryBase<Entity>(IDbRepositoryCommand<Entity> dbRepository, Entity entity) 
            : IConsultaQuery<IDbRepositoryCommand<Entity>, Entity> 
            where Entity : EntityCommand, new()
        {
            public IDbRepositoryCommand<Entity> DbRepository => dbRepository;
            public List<Entity> Execute() => DbRepository.GetAll(entity).ToList();
        }
    }

    internal class ConsultaApplicationQuery<Entity>(IDbRepositoryCommand<Entity> dbRepository, Entity entity)
        : ConsultaApplicationQueryBase<Entity>(dbRepository, entity) where Entity : EntityCommand, new()
    {
        public static explicit operator List<Entity>(ConsultaApplicationQuery<Entity> Query) => Query.Execute();
    }
}