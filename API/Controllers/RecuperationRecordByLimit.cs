using API.Entities;
using API.Data;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    public class RecuperationRecordByLimit
    {
    private readonly ControleContext _context;

    public RecuperationRecordByLimit(ControleContext context)
    {
        _context = context;
    }

    public async Task RecuperateRecords(JArray records)
        {
         IEnumerable<Record> recordsList =  new List<Record>();

                    foreach (JToken record in records)
                    {
                        recordsList = recordsList.Append(record["record"].ToObject<Record>());

                    }
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
}