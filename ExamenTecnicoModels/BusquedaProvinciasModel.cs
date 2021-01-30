using System.Collections.Generic;

namespace ExamenTecnico.Models
{
	public class BusquedaProvinciasModel
	{
		public IEnumerable<ProvinciaModel> Provincias { get; set; }
		public int Cantidad { get; set; }
		public int Total { get; set; }
		public int Inicio { get; set; }
	}
}
