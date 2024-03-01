using Newtonsoft.Json;

public class Field{
    //Tu peux supprimer les attributs qui ne sont pas utilisés
    //En théorie ça devrait toujours fonctionnés
    //Les champs sont mappés automatiquement avec ton JSON en fonction du nom
    //En C# pour les propriétés on utilise la convention PascalCase (la première lettre est en majuscule)
    //Comme dans en JSON les propriétés sont en camelCase (la première lettre est en minuscule) ou en snake_case (les mots sont séparés par des underscores)
    //comme ici, il faut rajouté une annotation pour lui dire comment mapper les propriétés
    
    //TODO
    //Rajouter les annotations pour mapper les propriétés

    public string Id { get; set; }

        [JsonProperty("cct_siret")]
        public string CctSiret { get; set; }
        public string CctDenomination { get; set; }
        public string CctAdresse { get; set; }
        public string CctCodeCommune { get; set; }
        public string CodePostal { get; set; }
        public string CctTel { get; set; }
        public string CctUrl { get; set; }
        public string Region { get; set; }
        public string CodeRegion { get; set; }
        public string Departement { get; set; }
        public string CodeDepartement { get; set; }
}