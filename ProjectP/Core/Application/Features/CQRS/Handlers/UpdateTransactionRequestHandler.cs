using MediatR;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Core.Domain;
using ProjectP.Core.Application.Features.CQRS.Commands;

namespace ProjectP.Core.Application.Features.CQRS.Handlers
{
    public class UpdateTransactionRequestHandler : IRequestHandler<UpdateTransactionCommandRequest>
    {
        private readonly IRepository<Transaction> repository;

        public UpdateTransactionRequestHandler(IRepository<Transaction> repository)
        {
            this.repository = repository;
        }

        public async Task<Unit> Handle(UpdateTransactionCommandRequest request, CancellationToken cancellationToken)
        {
            var updateTransaction = await this.repository.GetByIdAsync(request.Id);
            if (updateTransaction != null)
            {
                updateTransaction.Date=request.Date;
                updateTransaction.checkInOut = request.checkInOut;
                updateTransaction.WorkTime=request.WorkTime;
                await this.repository.UpdateAsync(updateTransaction);
            }
            return Unit.Value;
        }
    }
}
