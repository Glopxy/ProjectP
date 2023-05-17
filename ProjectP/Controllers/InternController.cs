using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PinternAPI.Core.Application.Features.CQRS.Commands;
using PinternAPI.Core.Application.Features.CQRS.Queries;

namespace PinternAPI.Controllers
{
    [Authorize(Roles ="Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class InternController : ControllerBase
    {
        private readonly IMediator mediator;

        public InternController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetAllInternsQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await this.mediator.Send(new GetInternQueryRequest(id));
            return result == null ? NotFound() : Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.mediator.Send(new DeleteInternCommandRequest(id));
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateInternCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }
    }
}
