using AutoMapper;
using PinternAPI.Core.Application.Dto;
using PinternAPI.Core.Domain;

namespace PinternAPI.Core.Application.Mappings
{
    public class InternProfile :Profile
    {
        public InternProfile() 
        { 
            this.CreateMap<Intern,InternListDto>().ReverseMap();
        }
    }
}
