using Microsoft.EntityFrameworkCore;
using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Infrasctruture
{
    public class DbRepositoryCommand : DbContext, IDbRepositoryCommand
    {
        public DbRepositoryCommand(DbContextOptions options) : base(options)
        {          
        }

        public IEnumerable<EntityCommand> GetAll(EntityCommand entityCommand)
            => new List<EntityCommand>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => base.OnConfiguring(optionsBuilder);
    }
}