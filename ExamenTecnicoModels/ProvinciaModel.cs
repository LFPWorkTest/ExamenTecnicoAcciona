namespace ExamenTecnico.Models
{
	public class ProvinciaModel
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public Centroide Centroide { get; set; }
	}

	public class Centroide { 
		public decimal Lat { get; set; }
		public decimal Lon { get; set; }
	}
}
