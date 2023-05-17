using MediatR;
using PinternAPI.Core.Application.Dto;

namespace PinternAPI.Core.Application.Features.CQRS.Queries
{
    public class GetInternQueryRequest : IRequest<InternListDto>
    {
        public int Id { get; set; }
        public GetInternQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
