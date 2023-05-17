using MediatR;
using ProjectP.Core.Application.Dto;

namespace ProjectP.Core.Application.Features.CQRS.Queries
{
    public class GetTransactionQueryRequest : IRequest<List<TransactionListDto>>
    {
    }
}
