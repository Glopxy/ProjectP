using AutoMapper;
using MediatR;
using PinternAPI.Core.Application.Dto;
using PinternAPI.Core.Application.Features.CQRS.Queries;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Core.Domain;

namespace PinternAPI.Core.Application.Features.CQRS.Handlers
{
    public class GetAllInternsQueryHandler : IRequestHandler<GetAllInternsQueryRequest, List<InternListDto>>
    {
        private readonly IRepository<Intern> repository;
        private readonly IMapper mapper;
        public GetAllInternsQueryHandler(IRepository<Intern> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<List<InternListDto>> Handle(GetAllInternsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetAllAsync();
            return this.mapper.Map<List<InternListDto>>(data);
        }
    }
}
