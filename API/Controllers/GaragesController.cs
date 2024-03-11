using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
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
            var response_2 =await httpClient.GetAsync("https://data.economie.gouv.fr/api/explore/v2.0/catalog/datasets/prix-des-controles-techniques-annuaire-des-centres/records?limit=100&offset="+offset+"&include_app_metas=False&include_links=False");
            
            string apiResponse = await response_2.Content.ReadAsStringAsync();
            JObject jObject = JObject.Parse(apiResponse);

            IList<JToken> records = jObject["records"].Children().ToList();
            string pageResponse= await response_2.Content.ReadAsStringAsync();

        //Debut fonction à part 
            IEnumerable<Record> recordsList =  new List<Record>();

                    foreach (JToken record in records)
                    {
                        recordsList = recordsList.Append(record["record"].ToObject<Record>());

                    }
                    //_context.Records.Add((Record)recordsList.Select(r => r.Fields));
                    IEnumerable<Field> fieldsList = recordsList.Select(r => r.Fields);
                    foreach (var fields in fieldsList)
                    {
                    if (fields != null)
                        {
                            _context.Fields.Add(fields);
                        }
                    }
                    await _context.SaveChangesAsync();
            }
            }
        //fin fonctionà part 
        
    return Ok();
        }
    }
}
