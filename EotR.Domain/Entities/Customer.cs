using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    [Index("Mail", "NickName", IsUnique = true)]
    [Index("NickName", IsUnique = true)]
    public class Customer
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string NickName { get; set; } = null!;

        public string? Avatar { get; set; }

        [Required]
        public string LastName { get; set; } = null!;

        [Required]
        public string FirstName { get; set; } = null!;

        public string Mail { get; set; } = null!;

        public bool IsAdmin { get; set; }

        public bool IsDeleted { get; set; }

        public Address Address { get; set; } = null!;


    }
}
