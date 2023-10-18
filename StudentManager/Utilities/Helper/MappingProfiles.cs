using AutoMapper;
using StudentManager.Models;
using StudentManager.Utilities.Dto;

namespace StudentManager.Utilities.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Student, StudentToReturnDto>()
                .ForMember(s => s.Class, o => o.MapFrom(s => s.Class.Name))
                .ForMember(s => s.Gender, o => o.MapFrom(s => s.Gender.Name));
            CreateMap<Student, StudentUpdateRequest>();
            
        }
    }
}
