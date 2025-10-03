using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    public class Monster
    {

        [Key]
        public long Id { get; set; }

        public string Type { get; set; } = null!;

        public string Name { get; set; } = null!;

        public int HP { get; set; }

        public int Mana { get; set; }

        public int Str { get; set; }

        public int Dex { get; set; }

        public int Intel { get; set; }

        public int Level { get; set; }

        public int XP { get; set; }

        public int Vita { get; set; }

        public int ResFire { get; set; }

        public int ResIce { get; set; }

        public int ResLightning { get; set; }

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }

        public int Gold { get; set; }

    }
}
