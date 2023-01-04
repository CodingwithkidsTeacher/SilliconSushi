using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename = ./sushis.sqlite");
        }

        public DbSet<Sushi> Sushis { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
  
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, Name = "Meat Sushi" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, Name = "Veggie Sushi" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, Name = "Vegetarian Sushi" });

         // seed sushis
            modelBuilder.Entity<Sushi>().HasData(new Sushi
            {
                SushiId = 4,
                Name = "Dragon Sushi Super",
                Price = 4M,
                ShortDescription = "Super Yummy Sushi",
                LongDescription = "This is the dragon sushi made of all veggies ingredients",
                InStock = true,
                ImageUrl = "https://i.ibb.co/QcZMNxm/makisushi.jpg",
                Allergy = "",
                SushiOfTheDay = true
            });

            modelBuilder.Entity<Sushi>().HasData(new Sushi
            {
                SushiId = 5,
                Name = "Miki Sushi",
                Price = 2M,
                ShortDescription = "Second Yummy Sushi",
                LongDescription = "This is the dragon sushi made of all veggies ingredients",
                InStock = true,
                ImageUrl = "https://i.ibb.co/f4H3PH6/rolls.jpg",
                Allergy = "",
                SushiOfTheDay = true
            });

            modelBuilder.Entity<Sushi>().HasData(new Sushi
            {
                SushiId = 6,
                Name = "Avocado Sushi",
                Price = 3M,
                ShortDescription = "Delicious Avocado Sushi",
                LongDescription = "Made with organic avocadoes, this healthy sushi is amazingly yummy!",
                InStock = true,
                ImageUrl = "https://i.ibb.co/xKTvpLz/avocado-sushi.jpg",
                Allergy = "",
                SushiOfTheDay = false

            }); 
        }
 
        
    }
}
