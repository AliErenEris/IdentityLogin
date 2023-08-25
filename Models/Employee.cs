using System.ComponentModel.DataAnnotations;

namespace IdentityLogin.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Age { get; set; }    
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; } 

    }
}
