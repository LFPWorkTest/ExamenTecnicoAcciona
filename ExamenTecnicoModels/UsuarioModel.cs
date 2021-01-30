using System.Collections.Generic;

namespace ExamenTecnico.Models
{
	public class UsuarioModel
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nickname { get; set; }
        public string Pwd { get; set; }
        public IEnumerable<RolModel> Roles { get; set; }
    }
}