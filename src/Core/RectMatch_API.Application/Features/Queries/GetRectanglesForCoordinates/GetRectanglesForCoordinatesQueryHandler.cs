using MediatR;
using RectMatch_API.Application.Features.Responses;
using RectMatch_API.Application.Interfaces.Repository;
using RectMatch_API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Application.Features.Queries
{
    public class GetRectanglesForCoordinatesQueryHandler : IRequestHandler<GetRectanglesForCoordinatesQuery, BaseResponseViewModel<List<Rectangle>>>
    {
        private readonly IRectangleRepository repository;

        public GetRectanglesForCoordinatesQueryHandler(IRectangleRepository repository)
        {
            this.repository = repository;
        }

        public Task<BaseResponseViewModel<List<Rectangle>>> Handle(GetRectanglesForCoordinatesQuery request, CancellationToken cancellationToken)
        {
            var rectangles = repository.GetRectanglesForCoordinates(request.Coordinates);

            var response = new BaseResponseViewModel<List<Rectangle>>()
            {
                Code = 0,
                Message = "Success",
                Data = rectangles,
            };

            return Task.FromResult(response);
        }
    }
}
