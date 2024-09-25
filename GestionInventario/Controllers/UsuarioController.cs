using Microsoft.AspNetCore.Mvc;
using GestionInventario.Data.Negocio.Servicios;
using GestionInventario.Data;

namespace GestionInventario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        [HttpGet("{Email}")] //Get by email
        public ActionResult<Usuario> Get(string Email){
            try{
                var usuario = _usuarioService.GetUsuarioByEmail(Email);

                if(usuario == null){
                    return NotFound();
                }
                return Ok(usuario);
            }catch (Exception ex){
                Console.WriteLine(ex.Message);
                return StatusCode(500,
                    new {
                        mensaje = "Ocurrio un error interno en el servidor", 
                        detalles = ex.Message
                        }
                );
            }
        }

        [HttpGet] //Get all users
        public ActionResult<List<Usuario>> Get(){
            try
            {
                var usuarios = _usuarioService.GetUsuarios();
                return Ok(usuarios);
            }catch (Exception ex){
                Console.WriteLine(ex.Message);
                return StatusCode(500,
                    new {
                        mensaje = "Ocurrio un error interno en el servidor", 
                        detalles = ex.Message
                        }
                );
            }
        }

        [HttpPost] //Created
        public ActionResult Post([FromBody] Usuario usuario){
            try{
                if(usuario == null){
                    return BadRequest();
                }
                _usuarioService.AddUsuario(usuario);
                return CreatedAtAction(nameof(Get), new {id = usuario.Id}, usuario);
            }catch (Exception ex){
                Console.WriteLine(ex.Message);
                return StatusCode(500,
                    new {
                        mensaje = "Ocurrio un error interno en el servidor", 
                        detalles = ex.Message
                        }
                );
            }
        }

        [HttpPut] //Updated
        public ActionResult Put(int Id, bool Estado){
            try{
                if(Id < 0){
                    return BadRequest();
                }
                _usuarioService.StateChange(Id, Estado);
                return Ok(new {mensaje = "Estado del suario actualizado correctamente"});
            }catch (Exception ex){
                Console.WriteLine(ex.Message);
                return StatusCode(500,
                    new {
                        mensaje = "Ocurrio un error interno en el servidor", 
                        detalles = ex.Message
                        }
                );
            }
        }
    }
}


