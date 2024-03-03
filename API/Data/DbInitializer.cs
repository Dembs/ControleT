//Seed data exemple
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ControleContext context)
        {
            if(context.Records.Any()) return;
            
            // var field = new List<Field>
            // {
            //     new Field
            //     {
            //         CctSiret = "12345678901234",
            //         CctDenomination = "Dummy Garage",
            //         CctAdresse = "123 Dummy Street",
            //         CctCodeCommune = "75001",
            //         CodePostal = "75001",
            //         CctUrl="test",
            //         CctTel = "0123456789",
            //         Region = "Île-de-France",
            //         CodeRegion = "11",
            //         Departement = "Paris",
            //         CodeDepartement = "75"
            //     },
                
            // };
            
            //We then add the product to our Data Base context
            
            // foreach (var fields in field)
            // {
            //     context.Field.Add(fields);
            // }

            context.SaveChanges();
        }
    }
}
