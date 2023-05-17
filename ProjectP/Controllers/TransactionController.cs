using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectP.Core.Application.Features.CQRS.Commands;
using ProjectP.Core.Application.Features.CQRS.Queries;
using System.Data;

namespace ProjectP.Controllers
{
    [Authorize(Roles = "Admin,Member")]
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator mediator;

        public TransactionController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var result = await this.mediator.Send(new GetTransactionQueryRequest());
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTransactionCommandRequest request)
        {
            await this.mediator.Send(request);
            return NoContent();
        }
    }
}
