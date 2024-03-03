using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{

public class Record
{
    public string Id { get; set; }
    public int Size {get; set;}
    public Field Fields { get; set; }
}
}