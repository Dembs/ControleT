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
                            var existingField = await _context.Fields.FindAsync(fields.CctSiret);
                            if (existingField !=null)
                            {
                                _context.Entry(existingField).CurrentValues.SetValues(fields);
                            }
                            else
                            {
                            _context.Fields.Add(fields);
                            }
                        }
                    }
                    await _context.SaveChangesAsync();
        }

    }
}