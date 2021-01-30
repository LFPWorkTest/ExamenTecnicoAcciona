using ExamenTecnico.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExamenTecnicoApi.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class ProvinciasController : Controller
    {
        [HttpGet("Buscar/{nombre}")]
        public async Task<ActionResult> Buscar(string nombre)
        {
            try
            {
                BusquedaProvinciasModel busquedaProvincias = new BusquedaProvinciasModel();

                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("https://apis.datos.gob.ar/georef/api/provincias?nombre=" + nombre))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        busquedaProvincias = JsonConvert.DeserializeObject<BusquedaProvinciasModel>(apiResponse);
                    }
                }

                return Ok(busquedaProvincias);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}