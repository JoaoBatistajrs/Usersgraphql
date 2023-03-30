using System.ComponentModel.DataAnnotations;

namespace UsersGraphQL.Models;

public class User
{
    [Key]
    public int Id { get; set; } 
    [Required]
    public string Name { get; set; }
    //public ICollection<Adress> Adresses { get; set; }
}
