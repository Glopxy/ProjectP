using MediatR;
using PinternAPI.Core.Application.Features.CQRS.Commands;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Core.Domain;

namespace PinternAPI.Core.Application.Features.CQRS.Handlers
{
    public class DeleteInternCommandHandler : IRequestHandler<DeleteInternCommandRequest>
    {
        private readonly IRepository<Intern> repository;

        public DeleteInternCommandHandler(IRepository<Intern> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(DeleteInternCommandRequest request, CancellationToken cancellationToken)
        {
            var deleteEntity = await this.repository.GetByIdAsync(request.Id);
            if (deleteEntity != null)
            {
                await this.repository.RemoveAsync(deleteEntity);
            }
            return Unit.Value;
        }
    }
}
