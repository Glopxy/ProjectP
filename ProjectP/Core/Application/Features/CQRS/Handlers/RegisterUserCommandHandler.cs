using MediatR;
using PinternAPI.Core.Domain;
using ProjectP.Core.Application.Features.CQRS.Commands;
using PinternAPI.Core.Application.Interfaces;
using ProjectP.Core.Application.Enums;
using AutoMapper.Execution;

namespace ProjectP.Core.Application.Features.CQRS.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommandRequest>
    {
        private readonly IRepository<Intern> repository;

        public RegisterUserCommandHandler(IRepository<Intern> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(RegisterUserCommandRequest request, CancellationToken cancellationToken)
        {
            await this.repository.CreateAsync(new Intern
            {

                NameSurname = request.NameSurname,
                UserName = request.UserName,
                Password = request.Password,
                Definition = request.Definition,
                StartDate = DateTime.Now,
                isActive = request.isActive,
                AppRoleId = (int)RoleType.Member,
                CreatedDate = DateTime.Now,

            });
            return Unit.Value;
        }
    }
}
