using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
[Keyless]
    public class Welcome
    {

        public long TotalCount { get; set; }
        public List<Link> Links { get; set; }
        public List<RecordElement> Records { get; set; }
    }

    public  class Link
    {
		public string Id {get; set;}

        public string Rel { get; set; }
        public Uri Href { get; set; }
    }
[Keyless]
    public  class RecordElement
    {
        public List<Link> Links { get; set; }
        public RecordRecord Record { get; set; }
    }

    public  class RecordRecord
    {
        public string Id { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public long Size { get; set; }
        public Fields Fields { get; set; }
    }

    public  class Fields
    {
		public string Id {get; set;}
        public string CctSiret { get; set; }
     /*   public List<long> CatVehiculeId { get; set; }
        public List<string> CatVehiculeLibelle { get; set; }
        public List<long> CatEnergieId { get; set; }
        public List<string> CatEnergieLibelle { get; set; }*/
        public string CctDenomination { get; set; }
        public string CctAdresse { get; set; }
        public string CctCodeCommune { get; set; }
        public string CodePostal { get; set; }
        public string CctTel { get; set; }
        public Uri CctUrl { get; set; }
        public string Region { get; set; }
        public long CodeRegion { get; set; }
        public string Departement { get; set; }
        public string CodeDepartement { get; set; }
    }
[Keyless]
    public  class Coordgeo
    {
		public string Id {get; set;}

        public double Lon { get; set; }
        public double Lat { get; set; }
    }
}