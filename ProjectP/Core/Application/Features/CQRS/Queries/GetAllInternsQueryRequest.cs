using MediatR;
using PinternAPI.Core.Application.Dto;

namespace PinternAPI.Core.Application.Features.CQRS.Queries
{
    public class GetAllInternsQueryRequest : IRequest<List<InternListDto>>
    {
    }
}