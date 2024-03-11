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
                var response = await httpClient.GetAsync("https://data.economie.gouv.fr/api/explore/v2.0/catalog/datasets/prix-des-controles-techniques-annuaire-des-centres/records");

                string mainResponse = await response.Content.ReadAsStringAsync();
                JObject jObjectMain = JObject.Parse(mainResponse);
                int total = int.Parse(jObjectMain["total_count"].ToString());

                _context.Fields.RemoveRange(_context.Fields);
                for (int i =0; i <= total; i =i+100)
                {
                    string offset = i.ToString();
                    var responseData =await httpClient.GetAsync("https://data.economie.gouv.fr/api/explore/v2.0/catalog/datasets/prix-des-controles-techniques-annuaire-des-centres/records?limit=100&offset="+offset+"&include_app_metas=False&include_links=False");
                    
                    string apiResponse = await responseData.Content.ReadAsStringAsync();
                    JObject jObject = JObject.Parse(apiResponse);

                    IList<JToken> records = jObject["records"].Children().ToList();

                    RecuperationRecordByLimit recuperation = new RecuperationRecordByLimit(_context);

                    await recuperation.RecuperateRecords(new JArray(records));
                }
            }

            return Ok();
        }
    }
}
