namespace GestionInventario.Data.Repositorio
{
    public interface IUsuarioRepository {
        List<Usuario> GetUsuarios();
        Usuario GetUsuarioByEmail(string Email);
        Usuario GetUsuarioById(int Id);
        void AddUsuario(Usuario usuario);
        bool StateChange(int Id, bool status);
        bool ValidarUsuario(string Email, string Contrasena);
    }
}