using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{

public class Fields
{
    public string Id {get; set;}
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

public class Record
{
    public string Id { get; set; }
    public Fields Fields { get; set; }
}

public class Root
{
    public string Id { get; set; }
    public List<Record> Records { get; set; }
}

}