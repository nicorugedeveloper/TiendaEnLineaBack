using Core.Entities;
using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Core.Services;

namespace WebApplication1.API.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UsuarioDto usuarioDto)
        {
            var usuario = new Usuario
            {
                Nombre = usuarioDto.Nombre,
                Correo = usuarioDto.Correo,
                Password = usuarioDto.Password 
            };

            var result = await _usuarioService.CreateUsuario(usuario);
            return Ok(result);
        }

       
    }

}
