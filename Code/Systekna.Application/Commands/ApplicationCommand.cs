using Systekna.Infrasctruture.Repository;

namespace Systekna.Commands
{
    public class ApplicationCommand(IDbRepositoryCommand db) 
        : AbstractApplicationCommand(db),  IApplicationCommand
    {
    }
}