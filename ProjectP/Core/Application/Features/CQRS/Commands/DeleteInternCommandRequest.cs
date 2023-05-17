using MediatR;

namespace PinternAPI.Core.Application.Features.CQRS.Commands
{
    public class DeleteInternCommandRequest : IRequest
    {
        public int Id { get; set; }
        public DeleteInternCommandRequest(int id) 
        {
            Id = id;
        }
    }
}
