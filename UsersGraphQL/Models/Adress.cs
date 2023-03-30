using System.ComponentModel.DataAnnotations;

namespace UsersGraphQL.Models;

public class Adress
{
    [Key]
    public int Id { get; set; } 
    [Required]
    public string Street { get; set; }
    [Required]
    public int City { get; set; }
    public long PostalCode { get; set; }
}
