using Microsoft.EntityFrameworkCore;
using RectMatch_API.Application.Interfaces.Repository;
using RectMatch_API.Domain.Entities;
using RectMatch_API.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Persistence.Repositories
{
    public class RectangleRepository : IRectangleRepository
    {
        private readonly ApplicationDbContext dbContext;

        public RectangleRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Rectangle> GetRectanglesForCoordinates(List<System.Drawing.Point> coordinates)
        {
            var sqlBuilder = new StringBuilder("SELECT * FROM Rectangles WHERE ");

            for (int i = 0; i < coordinates.Count; i++)
            {
                if (i > 0)
                    sqlBuilder.Append(" OR ");

                var coord = coordinates[i];
                sqlBuilder.Append($"(X1 <= {coord.X} AND X2 >= {coord.X} AND Y1 >= {coord.Y} AND Y2 <= {coord.Y})");
            }

            var sqlQuery = sqlBuilder.ToString();
            var rectangles = dbContext.Rectangles.FromSqlRaw(sqlQuery).ToList();

            return rectangles;
        }
    }
}
