using MediatR;
using PinternAPI.Core.Application.Features.CQRS.Commands;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Core.Domain;

namespace PinternAPI.Core.Application.Features.CQRS.Handlers
{
    public class UpdateInternCommandHandler : IRequestHandler<UpdateInternCommandRequest>
    {
        private readonly IRepository<Intern> repository;

        public UpdateInternCommandHandler(IRepository<Intern> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateInternCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedIntern = await this.repository.GetByIdAsync(request.Id);
            if (updatedIntern != null) 
            {
                updatedIntern.NameSurname = request.NameSurname;
                updatedIntern.UserName = request.UserName;
                updatedIntern.Password = request.Password;
                updatedIntern.Definition = request.Definition;
                updatedIntern.isActive = request.isActive;
                updatedIntern.UpdatedDate = DateTime.Now;
                await this.repository.UpdateAsync(updatedIntern);
            }
            return Unit.Value;
        }
    }
}
