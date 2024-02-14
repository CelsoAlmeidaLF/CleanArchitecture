using Systekna.Core.Entity;
using Systekna.Infrasctruture;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands
{
    public static class FactoryApplicationCommand
    {
        private static IDbRepositoryCommand<EntityCommand> ConfigRepository
            => new DbRepositoryCommand<EntityCommand>();
        public static IApplicationCommand<EntityCommand> Create 
            => new ApplicationCommand<EntityCommand>(ConfigRepository);
    }
}