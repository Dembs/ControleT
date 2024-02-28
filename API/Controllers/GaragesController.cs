using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GaragesController : ControllerBase
    {
        private readonly HttpClient _client;
        private readonly ControleContext _context;

        public GaragesController(HttpClient client, ControleContext context)
        {
            _client = client;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> SeedData()
        {
        using (var httpClient = new HttpClient())
        {
        using (var response = await httpClient.GetAsync("https://data.economie.gouv.fr/api/explore/v2.0/catalog/datasets/prix-des-controles-techniques-annuaire-des-centres/records"))
            {
            string apiResponse = await response.Content.ReadAsStringAsync();
            Root root = JsonConvert.DeserializeObject<Root>(apiResponse);

                    foreach (var record in root.Records)
                    {
                        /*if (record?.Fields != null)*/
                        
                            _context.Records.Add(record);
                        
                    }

                    await _context.SaveChangesAsync();

            }
        }

    return Ok();
        }
    }
}
