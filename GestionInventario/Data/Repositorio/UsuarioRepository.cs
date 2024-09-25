using GestionInventario.Data;
using GestionInventario.Data.Negocio.Servicios;
using Microsoft.AspNetCore.Http.HttpResults;

namespace GestionInventario.Data.Repositorio
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private static readonly List<Usuario> usuarios = new List<Usuario>();

        static UsuarioRepository(){
            for(int i = 0; i < 5;i++){
                var nombre = DataGenerator.GenerateRandomName();
                usuarios.Add(new Usuario
                {
                    Id = i,
                    Nombre = nombre,
                    Apellido = DataGenerator.GenerateRandomLastName(),
                    TipoDocIdent = DataGenerator.GenerateRandomTipoDocIdent(),
                    NumDocIdent = DataGenerator.GenerateRandomNumDocIdent(),
                    Email = DataGenerator.GenerateRandomEmail(nombre),
                    Contrasena = DataGenerator.GenerateRandomPassword(),
                    Direccion = DataGenerator.GenerateRandomAddress(),
                    Telefono = DataGenerator.GenerateRandomPhone(),
                    Estado = DataGenerator.GenerateRandomEstado()
                });
            }
        }

        public void AddUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
        
        public void UpdateUsuario(Usuario usuario)
        {
            var indice = usuarios.FindIndex(c => c.Id == usuario.Id);
            if(indice > -1){
                usuarios[indice] = usuario;
            }
        }

        public Usuario? GetUsuarioByEmail(string Email)
        {
            var usuario = usuarios.FirstOrDefault(c => c.Email == Email);
            return usuario;
        }

        public Usuario? GetUsuarioById(int Id)
        {
            var usuario = usuarios.FirstOrDefault(c => c.Id == Id);
            return usuario;
        }

        public List<Usuario> GetUsuarios()
        {
            return usuarios;
        }

        public bool StateChange(int Id, bool status){
            var usuario = usuarios.FirstOrDefault(c => c.Id == Id);
            if(usuario != null){
                usuario.Estado = status;
                return true;
            }
            return false;
        }

        public bool ValidarUsuario(string Email, string Contrasena)
        {
            bool YoN = false;
            var usuarioValido = usuarios.FirstOrDefault(c => c.Email == Email && c.Contrasena == Contrasena);
            if(usuarioValido != null){
                YoN = true;
            }
            return YoN;
        }
    }
}


