using API.Entities;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

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
                    JObject jObject = JObject.Parse(apiResponse);
                    IList<JToken> records = jObject["records"].Children().ToList();

                    IEnumerable<Record> recordsList = new List<Record>();

                    foreach (JToken record in records)
                    {
                        //record est un objet qui contient les champs de ton JSON
                        //Tu as link et record à l'intérieur

                        //Le ToObject est un raccourci pour désérialiser le JSON en objet Record
                        recordsList = recordsList.Append(record["record"].ToObject<Record>());
                    }

                    //TODO Insérer en base les infos

                    await _context.SaveChangesAsync();
                }
            }

            return Ok();
        }
    }
}
