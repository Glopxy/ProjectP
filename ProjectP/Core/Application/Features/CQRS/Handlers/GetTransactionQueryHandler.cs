using AutoMapper;
using MediatR;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Core.Domain;
using ProjectP.Core.Application.Dto;
using ProjectP.Core.Application.Features.CQRS.Queries;

namespace ProjectP.Core.Application.Features.CQRS.Handlers
{
    public class GetTransactionQueryHandler : IRequestHandler<GetTransactionQueryRequest, List<TransactionListDto>>
    {
        private readonly IRepository<Transaction> repository;
        private readonly IMapper mapper;
        public GetTransactionQueryHandler(IRepository<Transaction> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<TransactionListDto>> Handle(GetTransactionQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();
            return this.mapper.Map<List<TransactionListDto>>(data);
        }
    }
}
