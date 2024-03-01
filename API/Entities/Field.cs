using Newtonsoft.Json;

public class Field{
    //Tu peux supprimer les attributs qui ne sont pas utilis�s
    //En th�orie �a devrait toujours fonctionn�s
    //Les champs sont mapp�s automatiquement avec ton JSON en fonction du nom
    //En C# pour les propri�t�s on utilise la convention PascalCase (la premi�re lettre est en majuscule)
    //Comme dans en JSON les propri�t�s sont en camelCase (la premi�re lettre est en minuscule) ou en snake_case (les mots sont s�par�s par des underscores)
    //comme ici, il faut rajout� une annotation pour lui dire comment mapper les propri�t�s
    
    //TODO
    //Rajouter les annotations pour mapper les propri�t�s

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