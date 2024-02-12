//Seed data exemple
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ControleContext context)
        {
            if(context.Garages.Any()) return;
            
            var garages = new List<Garage>
            {
                new Garage
                {
                    Nom = "On est les moins chers",
                    Departement ="Departement",
                    Prix = 10,
                    Ville = "PasLoin",
                    PrixMaxCV = 8,
                    PrixMinCV = 5,
                    Adresse = "Rue du test",
                    CodePostal="10000",
                    TypeVehicule="",
                    Energie="Diesel",
                    SiteWeb="https://onestlesmoinschers.fr",
                    Telephone="0101010101"
                },
                
						};
						
						//We then add the product to our Data Base context
            // context.Products.AddRange(products);
            foreach (var garage in garages)
            {
                context.Garages.Add(garage);
            }

            context.SaveChanges();
        }
    }
}