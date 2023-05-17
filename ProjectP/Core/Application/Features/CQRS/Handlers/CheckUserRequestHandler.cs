using MediatR;
using PinternAPI.Core.Application.Interfaces;
using PinternAPI.Core.Domain;
using ProjectP.Core.Application.Dto;
using ProjectP.Core.Application.Features.CQRS.Queries;

namespace ProjectP.Core.Application.Features.CQRS.Handlers
{
    public class CheckUserRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<AppRole> roleRepository;
        private readonly IRepository<Intern> userRepository;

        public CheckUserRequestHandler(IRepository<AppRole> roleRepository, IRepository<Intern> internRepository)
        {
            this.roleRepository = roleRepository;
            this.userRepository = internRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await this.userRepository.GetByFilterAsync(x => x.UserName ==
                request.Username && x.Password == request.Password);

            if (user == null)
            {
                dto.IsExist = false;
            }
            else
            {
                dto.UserName = user.UserName;
                dto.Id = user.Id;
                dto.IsExist = true;
                var role = await this.roleRepository.GetByFilterAsync(x => x.Id == user.AppRoleId);
                dto.Role = role?.Definition;
            }


            return dto;
        }
    }


}
