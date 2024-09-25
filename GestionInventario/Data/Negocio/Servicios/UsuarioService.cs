using GestionInventario.Data.Repositorio;

namespace GestionInventario.Data.Negocio.Servicios{
    public class UsuarioService : IUsuarioService
    {
        private static readonly List<Usuario> usuarios = new List<Usuario>();
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }

        public void AddUsuario(Usuario usuario)
        {
            _usuarioRepository.AddUsuario(usuario);
        }

        public Usuario GetUsuarioByEmail(string Email)
        {
            return _usuarioRepository.GetUsuarioByEmail(Email);
        }

        public Usuario GetUsuarioById(int Id)
        {
            return _usuarioRepository.GetUsuarioById(Id);
        }

        public List<Usuario> GetUsuarios()
        {
            return _usuarioRepository.GetUsuarios();
        }

        public bool StateChange(int Id, bool Estado)
        {
            return _usuarioRepository.StateChange(Id, Estado);
        }

        public bool ValidarUsuario(string Email, string Contrasena)
        {
            return _usuarioRepository.ValidarUsuario(Email, Contrasena);
        }
    }
}



