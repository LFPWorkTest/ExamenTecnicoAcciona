using ExamenTecnico.Data;
using ExamenTecnico.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExamenTecnicoApi.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly UsuariosData _usuariosData;

        public UsuarioController(ExamenTecnicoDBContext context)
        {
            _usuariosData = new UsuariosData(context);

            _usuariosData.VerificarUsuarioBase();
        }

        [HttpPost("Login")]
        public ActionResult Login(UsuarioModel loginUsr)
        {
            try
            {
                loginUsr = _usuariosData.LoguearUsuario(loginUsr);
                
                return Ok("Login Ok.");
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
