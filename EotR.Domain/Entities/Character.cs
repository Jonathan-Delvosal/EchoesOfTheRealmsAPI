using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    public class Character
    {

        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? Sprite { get; set; }

        public bool IsDeleted { get; set; }

        #region Doublons DB
        public long? HelmetID { get; set; }
        
        public Equipment? Helmet { get; set; }

        public long? ArmorID { get; set; }
        
        public Equipment? Armor { get; set; }

        public long? BootID { get; set; }
        
        public Equipment? Boot { get; set; }

        public long? WeaponId { get; set; }
        
        public Equipment? Weapon { get; set; }

        public int JobId { get; set; }
        
        public Job Job { get; set; }

        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; } 

        public long InventoryId { get; set; }

        public Inventory Inventory { get; set; } 
        #endregion

      


    }
}
