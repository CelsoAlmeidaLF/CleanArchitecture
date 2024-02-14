using Systekna.Core.ValueObject;

namespace Systekna.Core.Entity.Base
{
    public abstract class EntityBase
    {
        public int? ID { get; set; } = null;
        public DateTime? DtCriação { get; set; } = DateTime.Now;
        public DateTime DtAlteração { get; set; } = DateTime.Now;
        public Bloqueio Bloqueio { get; set; } = true;
        public UsuarioLogado UsuarioResponsavel { get; set; } = Environment.UserName;
    }
}
