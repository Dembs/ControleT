//Seed data exemple
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ControleContext context)
        {
            if(context.Field.Any()) return;
            
            var garages = new List<Fields>
            {
                new Fields
                {
                    CctSiret = "12345678901234",
                   /* CatVehiculeId = new List<long> { 1, 2, 3 },
                    CatVehiculeLibelle = new List<string> { "Car", "Truck", "Bike" },
                    CatEnergieId = new List<long> { 1, 2 },
                    CatEnergieLibelle = new List<string> { "Gasoline", "Diesel" },*/
                    CctDenomination = "Dummy Garage",
                    CctAdresse = "123 Dummy Street",
                    CctCodeCommune = "75001",
                    CodePostal = "75001",
                    CctTel = "0123456789",
                    CctUrl = new Uri("http://www.dummy-garage.com"),
                    Region = "Île-de-France",
                    CodeRegion = 11,
                    Departement = "Paris",
                    CodeDepartement = "75"
                },
                
            };
            
            //We then add the product to our Data Base context
            // context.Products.AddRange(products);
            foreach (var fields in garages)
            {
                context.Field.Add(fields);
            }

            context.SaveChanges();
        }
    }
}
