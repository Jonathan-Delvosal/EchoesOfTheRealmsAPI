using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    public class Equipment
    {

        [Key]
        public long Id { get; set; }

        public string Type { get; set; } = null!;

        public string Materials { get; set; } = null!;

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string FlavorText { get; set; } = null!;

        public int ModHP { get; set; }

        public int ModMana { get; set; }

        public int ModStr { get; set; }

        public int ModDex { get; set; }

        public int ModIntel { get; set; }

        public int ModLVL { get; set; }

        public int BuyPrice { get; set; }

        public int SellPrice { get; set; }

        public int ModVita { get; set; }

        public int ModResFire { get; set; }

        public int ModResIce { get; set; }

        public int ModResLightning { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }

    }
}
