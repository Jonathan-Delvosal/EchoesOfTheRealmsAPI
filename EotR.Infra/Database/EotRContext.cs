using Microsoft.EntityFrameworkCore;
using EchoesOfTheRealms.Entities;

namespace EotR.Infra.Database
{
    public class EotRContext (DbContextOptions options) : DbContext(options)
    {

        public DbSet<Address> Adress { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Job> Classes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Monster> Monsters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData([
                new Customer{ Id = 1, NickName = "Hakuryu", LastName = "Delvosal", FirstName = "Jonathan", Mail = "jonathan.delvosal@outlook.com", IsAdmin = true, IsDeleted = false  }
                ]);

            modelBuilder.Entity<Address>().HasData([
                new Address{ Id = 1, Street = "Chaussée de Waterloo", Number = 136, NumberComp = 0011, City = "Namur", PostalCode = 5002, Country = "Belgique", CustomerId = 1}
                ]);

            modelBuilder.Entity<Equipment>().HasData([

                new Equipment{ Id = 150000000001, Type = "Casque", Materials = "Cuir", Name = "Casque en cuir", Description = "Un petit casque en cuir.", FlavorText = "Récupéré sur un soldat tombé au combat, il peut encore servir.", ModVita = 10, ModResFire = 5, ModResIce = 5, ModResLightning = 20, BuyPrice = 10, SellPrice = 5, IsDeleted = false},

                new Equipment{ Id = 160000000001, Type = "Armure", Materials = "Tissu", Name = "Armure en tissu", Description = "Une simple toge en fin coton.", FlavorText = "Tissé avec amour par les tisserandes du village pour les fiers guérrier.", ModVita = 20, ModResFire = 5, ModResIce = 20, ModResLightning = 5, BuyPrice = 10, SellPrice = 5, IsDeleted = false},

                new Equipment{ Id = 170000000001, Type = "Botte", Materials = "Metal", Name = "Bottes en métal", Description = "Des bottes de plates légère.", FlavorText = "Impossible d'avoir froid aux pieds lors des expéditions avec de telles bottes.", ModVita = 10, ModResFire = 20, ModResIce = 5, ModResLightning = 5, BuyPrice = 10, SellPrice = 5, IsDeleted = false},

                new Equipment{ Id = 110000000001, Type = "Epee", Materials = "Bronze", Name = "Epée de bronze", Description = "Une simple épée de bronze.", FlavorText = "Une épée de débutant, parfaite pour occire vos premiers monstres.", ModStr = 10, BuyPrice = 10, SellPrice = 5, IsDeleted = false},

                new Equipment{ Id = 140000000001, Type = "Baton", Materials = "Bois", Name = "Bâton d'apprenti Mage", Description = "Un bâton de bois infusé de magie.", FlavorText = "Taillé dans un arbre millénaire, ce bâton est offert à chaque nouvel apprenti mage par son mentor.", ModIntel = 10, BuyPrice = 10, SellPrice = 5, IsDeleted = false},

                new Equipment{ Id = 130000000001, Type = "Arc", Materials = "Bois", Name = "Arc en bois", Description = "Un arc en bois courbé.", FlavorText = "Façonné à partir d'une belle branche de noisetier, cet arc vous fera chasser de gros lapin.", ModDex = 10, BuyPrice = 10, SellPrice = 5, IsDeleted = false},

                ]);

            modelBuilder.Entity<Job>().HasData([
                new Job { Id = 1, Name = "Guerrier", HP = 150, Mana = 50, Str = 100, Dex = 50, Intel = 25, Vita = 100, Level = 1, XP = 0, ResFire = 10, ResIce = 10, ResLightning = 10, IsDeleted = false },

                new Job { Id = 2, Name = "Voleur", HP = 100, Mana = 50, Str = 50, Dex = 100, Intel = 25, Vita = 100, Level = 1, XP = 0, ResFire = 5, ResIce = 5, ResLightning = 5, IsDeleted = false },

                new Job { Id = 3, Name = "Mage", HP = 100, Mana = 100, Str = 25, Dex = 50, Intel = 100, Vita = 100, Level = 1, XP = 0, ResFire = 15, ResIce = 15, ResLightning = 15, IsDeleted = false },

                ]);

            modelBuilder.Entity<Inventory>().HasData([
                new Inventory { Id = 1, Gold = 0}
                ]);

            modelBuilder.Entity<Character>().HasData([
                new Character { Id = 1, Name = "Haku", IsDeleted = false, CustomerId = 1, JobId = 1, HelmetID = 150000000001, ArmorID = 160000000001, BootID = 170000000001, WeaponId = 110000000001, InventoryId = 1}
                ]);

            modelBuilder.Entity<Monster>().HasData([
                new Monster{ Id = 1, Type = "Loup", Name = "Loup des steppes", HP = 30, Mana = 1, Level = 1, Str = 10, Dex = 40, Intel = 25, Vita = 30, ResFire = 5, ResIce = 20, ResLightning = 5, XP = 25, Gold = 10, IsDeleted = false}
                ]);

            modelBuilder.Entity<Item>().HasData([
                new Item{ Id = 210000000001, Type = "Potion", Name = "Potion de soin", Description = "Une simple potion de soin.", FlavorText = "Une petite potion qui vous rendra quelques points de vie, afin de tenir jusqu'à la fin du combat.", BuyPrice = 10, SellPrice = 5, IsDeleted = false}
                ]);

        }

    }
}
