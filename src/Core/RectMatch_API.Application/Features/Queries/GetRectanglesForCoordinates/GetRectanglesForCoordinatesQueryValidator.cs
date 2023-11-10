using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectMatch_API.Application.Features.Queries.GetRectanglesForCoordinates
{
    public class GetRectanglesForCoordinatesQueryValidator : AbstractValidator<GetRectanglesForCoordinatesQuery>
    {
        public GetRectanglesForCoordinatesQueryValidator()
        {
            RuleFor(i => i.Coordinates)
                .NotNull()
                .NotEmpty();
        }
    }
}
