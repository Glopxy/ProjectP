using MediatR;

namespace PinternAPI.Core.Application.Features.CQRS.Commands
{
    public class UpdateInternCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string? NameSurname { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Definition { get; set; }
        public Boolean isActive { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
