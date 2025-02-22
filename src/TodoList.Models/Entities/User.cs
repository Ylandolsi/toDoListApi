using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Name Required ") , MaxLength(50 , ErrorMessage = "Name is Too long ") , MinLength(3  , ErrorMessage = "Name is too shrot ") ]
    public string Name { get; set; }
    [Required(ErrorMessage = "Position Required")]
    public string position { get; set; }
    
    public string Username { get; set; }
    public string PasswordHash { get; set; } // Store hashed passwords, not plain text
    public string Role { get; set; } // e.g., "Admin", "User"
    
    // tasks done ? 
    public ICollection<Tasks> Tasks { get; set; }
    

}
