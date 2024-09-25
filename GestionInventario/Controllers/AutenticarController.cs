using Microsoft.AspNetCore.Mvc;
using GestionInventario.Data.Negocio.Servicios;
using GestionInventario.Data;

namespace GestionInventario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutenticarController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public AutenticarController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        [HttpPost(" Validar usuario")] //Authenticate user
        public ActionResult Post(UsuarioValido usuario){
            bool esValido =  _usuarioService.ValidarUsuario(usuario.Email, usuario.Contrasena);

            if (esValido != false)
            {
                var usuarioAutenticado = _usuarioService.GetUsuarioByEmail(usuario.Email);
                return Ok(new{
                    AutenticacionExitosa = true,
                    Jwt = Guid.NewGuid().ToString(),
                    Mensaje = $"Bienvenido {usuarioAutenticado.Nombre} {usuarioAutenticado.Apellido}"
                });
            }else{
                return Unauthorized(new{
                    AutenticacionExitosa = false,
                    Jwt = (string?)null,
                    Mensaje = "Error al autenticar el usuario"
                });
            }
        }
    }
}


