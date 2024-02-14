namespace Systekna.Core.ValueObject;

public readonly struct UsuarioLogado(string usuario, DateTime dtLogin)
{
    public readonly string UsuerLogin = usuario;
    public readonly DateTime? DateLogin = !String.IsNullOrEmpty(usuario) ? dtLogin : null;

    public static implicit operator UsuarioLogado(string usuario) 
        => new UsuarioLogado(usuario, DateTime.Now);

    public override string ToString()
    {
        return $"{UsuerLogin} ({DateLogin})";
    }
}