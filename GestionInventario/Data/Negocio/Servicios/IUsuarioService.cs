namespace GestionInventario.Data.Negocio.Servicios
{
    public interface IUsuarioService
    {
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioById(int Id);
        Usuario GetUsuarioByEmail(string Email);
        void AddUsuario(Usuario usuario);
        bool StateChange(int Id, bool Estado);
        bool ValidarUsuario(string Email, string Contrasena);
    }
}


