using AutoMapper;
using MediatR;
using PinternAPI.Core.Application.Dto;
using PinternAPI.Core.Application.Features.CQRS.Queries;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Core.Domain;

namespace PinternAPI.Core.Application.Features.CQRS.Handlers
{
    public class GetInternQueryHandler : IRequestHandler<GetInternQueryRequest, InternListDto>
    {
        private readonly IRepository<Intern> repository;
        private readonly IMapper mapper;

        public GetInternQueryHandler(IRepository<Intern> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<InternListDto> Handle(GetInternQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
            return this.mapper.Map<InternListDto>(data);
        }
    }
}
