using System.ComponentModel.DataAnnotations;
using API.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API.Entities
{

public class Field
{
    public string Id {get; set;}
    [JsonProperty("cct_siret")]
    public string CctSiret { get; set; }
    [JsonProperty("cct_denomination")]
    public string CctDenomination { get; set; }
    [JsonProperty("cct_adresse")]
    public string CctAdresse { get; set; }
       [JsonProperty("cct_code_commune")]
        public string CctCodeCommune { get; set; }

        [JsonProperty("code_postal")]
        public string CodePostal { get; set; }

        [JsonProperty("cct_tel")]
        public string CctTel { get; set; }

        [JsonProperty("cct_url")]
        public string CctUrl { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("code_region")]

        public string CodeRegion { get; set; }

        [JsonProperty("departement")]
        public string Departement { get; set; }

        [JsonProperty("code_departement")]
        public string CodeDepartement { get; set; }
    }
}


/*public class Root
{
    public string Id { get; set; }
    public List<Record> Records { get; set; }
}*/


