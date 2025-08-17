namespace Universe.Service
{
    public class UserMapper : AutoMapper.Profile
    {
        public UserMapper()
        {
			//CreateMap<Users, User>()
		 //  .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
		 //  .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
		 //  .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
		 //  .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
		 //  .ForMember(dest => dest.BirthYear, opt => opt.MapFrom(src => src.Birthday.Year))
		 //  .ForMember(dest => dest.BirthMonth, opt => opt.MapFrom(src => src.Birthday.Month))
		 //  .ForMember(dest => dest.BirthDay, opt => opt.MapFrom(src => src.Birthday.Day))
		 //  .ForMember(dest => dest.OccupationName, opt => opt.Ignore())

			CreateMap<Core.UserRegisterDto, Core.User>().ReverseMap();
            CreateMap<Core.UserUpdateDto, Core.User>().ReverseMap();
			CreateMap<Common.UserResponse, Core.User>().ReverseMap();
		}
    }
}