using MediatR;

namespace ProjectP.Core.Application.Features.CQRS.Commands
{
    public class RegisterUserCommandRequest : IRequest
    {
        public int AppRoleId { get; set; }
        public string? NameSurname { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Definition { get; set; }
        public DateTime StartDate { get; set; }
        public Boolean isActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
