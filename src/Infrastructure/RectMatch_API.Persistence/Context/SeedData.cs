using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RectMatch_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Persistence.Context
{
    internal static class SeedData
    {
        private static readonly Random random = new();

        public static Task SeedAsync(IConfiguration configuration)
        {
            var dbContextOptionsBuilder = new DbContextOptionsBuilder();
            dbContextOptionsBuilder.UseSqlServer(configuration["ConnectionString"]);

            var context = new ApplicationDbContext(dbContextOptionsBuilder.Options);
            var data = GetSeedData(count: 200, maxWidth: 1000, maxHeight: 1000);

            if (!context.Rectangles.Any())
            {
                context.Rectangles.AddRange(data);
                context.SaveChanges();
            }

            return Task.FromResult(0);
        }

        private static Rectangle[] GetSeedData(int count, int maxWidth, int maxHeight)
        {
            Rectangle[] array = new Rectangle[200];

            for (int i = 0; i < count; i++)
            {
                // Generate coordinates such that x2 > x1 and y1 > y2
                int x1 = random.Next(0, maxWidth);
                int x2 = random.Next(x1 + 1, maxWidth + 1); // Ensure x2 is always greater than x1

                int y2 = random.Next(0, maxHeight);
                int y1 = random.Next(y2 + 1, maxHeight + 1); // Ensure y1 is always greater than y2

                array[i] = new Rectangle
                {
                    X1 = x1,
                    Y1 = y1,
                    X2 = x2,
                    Y2 = y2
                };
            }

            return array;
        }
    }
}
