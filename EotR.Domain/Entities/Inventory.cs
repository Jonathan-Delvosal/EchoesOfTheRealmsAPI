using System.ComponentModel.DataAnnotations;

namespace EchoesOfTheRealms.Entities
{
    public class Inventory
    {

        [Key]
        public long Id { get; set; }

        public int Gold { get; set; }

        //list item
        //list equipement
        //pareil de l'autre coté en liste

        //list sur monstre pour items et equip

    }
}
