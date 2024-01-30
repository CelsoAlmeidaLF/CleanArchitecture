using Systekna.Infrasctruture;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands
{
    public static class FactoryApplicationCommand
    {
        private static IDbRepositoryCommand ConfigRepository
            => new DbRepositoryCommand();
        public static IApplicationCommand Create 
            => new ApplicationCommand(ConfigRepository);
    }
}