using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RectMatch_API.Application.Features.Queries;

namespace RectMatch_API.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RectangleController : ControllerBase
    {
        private readonly IMediator mediator;

        public RectangleController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GetRectanglesForCoordinatesQuery query)
        {
            var result = await mediator.Send(query);

            return Ok(result);
        }
    }
}
