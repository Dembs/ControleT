namespace API.Entities
{
    public class Garage
    {
		public int Id {get; set;}
		public string Nom {get; set;}

		public string Departement {get; set;}
		public string CodePostal {get; set;}

		public long Prix {get; set;}
		public string Ville {get; set;}
		public string Telephone {get; set;}
		public string SiteWeb {get; set;}
		public string Adresse {get; set;}
		public string TypeVehicule {get; set;}

		public string Energie {get; set;}

		public long PrixMinCV {get; set;}

		public long PrixMaxCV {get; set;}

    }
}