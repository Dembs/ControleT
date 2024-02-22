using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GaragesController : ControllerBase
    {
        private readonly HttpClient _client;

        public GaragesController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> CallApi()
        {
            var response = await _client.GetAsync("https://data.economie.gouv.fr/api/explore/v2.0/catalog/datasets/prix-des-controles-techniques-annuaire-des-centres/records");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }

            return BadRequest();
        }
    }
}
