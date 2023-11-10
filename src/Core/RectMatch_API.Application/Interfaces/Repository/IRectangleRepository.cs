using RectMatch_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Application.Interfaces.Repository
{
    public interface IRectangleRepository
    {
        List<Rectangle> GetRectanglesForCoordinates(List<System.Drawing.Point> coordinates);
    }
}
