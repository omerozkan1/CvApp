using AutoMapper;
using CvApp.DTO.DTOs.AppUserDtos;
using CvApp.Entities.Concrete;

namespace CvApp.DataAccess.Concrete.Mapping
{
    public class AppUserListMapping : Profile
    {
        public AppUserListMapping()
        {
            CreateMap<AppUser, AppUserListDto>();
            CreateMap<AppUserListDto, AppUser>();
        }
    }
}
