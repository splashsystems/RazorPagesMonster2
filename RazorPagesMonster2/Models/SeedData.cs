using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMonster2.Data;

namespace RazorPagesMonster2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMonster2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMonster2Context>>()))
            {
                // Look for any monsters.
                if (context.Monster.Any())
                {
                    return;   // DB has been seeded
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        MonsterName = "Psycho",
                        OriginDate = DateTime.Parse("1960-9-8"),
                        Genre = "Crazy Dudes",
                        Price = 1.25M
                    },

                    new Monster
                    {
                        MonsterName = "Slimer",
                        OriginDate = DateTime.Parse("1984-6-8"),
                        Genre = "Ghosts",
                        Price = 32.00M
                    },

                    new Monster
                    {
                        MonsterName = "Tom(Tom and Jerry)",
                        OriginDate = DateTime.Parse("1940-7-1"),
                        Genre = "Cartoon Animal Bullys",
                        Price = 4.50M
                    },

                    new Monster
                    {
                        MonsterName = "Godzilla",
                        OriginDate = DateTime.Parse("1954-7-1"),
                        Genre = "Radioactive Dinosaurs",
                        Price = 57.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
