using MediatR;
using RectMatch_API.Application.Features.Responses;
using RectMatch_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Application.Features.Queries
{
    public class GetRectanglesForCoordinatesQuery : IRequest<BaseResponseViewModel<List<Domain.Entities.Rectangle>>>
    {
        public List<Point> Coordinates { get; set; }

        public GetRectanglesForCoordinatesQuery(List<Point> coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
