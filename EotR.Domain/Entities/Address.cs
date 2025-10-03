using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    public class Address
    {

        [Key]
        public int Id { get; set; }

        public string Street { get; set; } = null!;

        public int Number { get; set; }

        public int NumberComp { get; set; }

        public string City { get; set; }

        public int PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        #region Doublons DB
        public Customer Customer { get; set; } = null!;

        public int CustomerId { get; set; }

        #endregion


    }
}
