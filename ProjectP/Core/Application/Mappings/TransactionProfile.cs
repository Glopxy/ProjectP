using AutoMapper;
using PinternAPI.Core.Domain;
using ProjectP.Core.Application.Dto;

namespace ProjectP.Core.Application.Mappings
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            this.CreateMap<Transaction,TransactionListDto>().ReverseMap();
        }
    }
}
