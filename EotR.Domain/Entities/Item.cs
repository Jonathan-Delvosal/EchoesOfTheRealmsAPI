using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    public class Item
    {

        [Key]
        public long Id { get; set; }

        public string Type { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string FlavorText { get; set; } = null!;

        public string? Effect { get; set; }

        public int BuyPrice { get; set; }

        public int SellPrice { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }
    }
}
