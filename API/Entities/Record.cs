namespace API.Entities
{
    public class Record
    {
        //Tu peux supprimer les attributs qui ne sont pas utilisés
        //En théorie ça devrait toujours fonctionné, évidemment il faut garder le l'attributs Fields
        //Les champs sont mappés automatiquement avec ton JSON
        public string Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int Size { get; set; }
        public Field Fields { get; set; }
    }
}
