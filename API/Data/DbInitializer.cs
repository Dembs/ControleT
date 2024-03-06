using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ControleContext context)
        {
            if(context.Records.Any()) return;

            context.SaveChanges();
        }
    }
}
