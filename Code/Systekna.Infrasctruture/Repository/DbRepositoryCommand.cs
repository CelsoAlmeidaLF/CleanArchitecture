using Microsoft.EntityFrameworkCore;
using Systekna.Core.Entity;
using Systekna.Infrasctruture.Repository;

namespace Systekna.Infrasctruture
{
    public class DbRepositoryCommand<Entity> : DbContext, IDbRepositoryCommand<Entity> where Entity : EntityCommand, new()
    {
        public IEnumerable<Entity> GetAll(Entity entity)
            => new List<Entity>() { entity };

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => base.OnConfiguring(optionsBuilder);
    }
}