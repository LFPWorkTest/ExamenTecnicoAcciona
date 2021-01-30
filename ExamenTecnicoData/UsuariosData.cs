using ExamenTecnico.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamenTecnico.Data
{
	public class UsuariosData
    {
        private readonly ExamenTecnicoDBContext _context;

        public UsuariosData(ExamenTecnicoDBContext context) {
            _context = context;
        }

        public void VerificarUsuarioBase() {
            if (_context.UsuariosLista.Count() == 0)
            {
                _context.UsuariosLista.Add(new UsuarioModel
                {
                    Nombre = "Fidel",
                    Apellido = "Perez",
                    Nickname = "test",
                    Pwd = "123",
                    Roles = new List<RolModel>{
                        new RolModel
                        {
                            Descripcion = "Usuario de Prueba"
                        }
                    }
                });

                _context.SaveChanges();
            }
        }

        public UsuarioModel LoguearUsuario(UsuarioModel loginUsr)
        {
            loginUsr = ValidarUsuario(loginUsr);

            if (loginUsr == null)
                throw new Exception("Usuario o contraseña inválida.");

            return loginUsr;
        }

        private UsuarioModel ValidarUsuario(UsuarioModel loginUsr) {
            return _context.UsuariosLista.SingleOrDefault(usuario => (usuario.Nickname == loginUsr.Nickname && usuario.Pwd == loginUsr.Pwd));
        }
    }
}