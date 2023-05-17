using MediatR;

namespace ProjectP.Core.Application.Features.CQRS.Commands
{
    public class UpdateTransactionCommandRequest : IRequest
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? checkInOut { get; set; }
        public string? WorkTime { get; set; }
    }
}
