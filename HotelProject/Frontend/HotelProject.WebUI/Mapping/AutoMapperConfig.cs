using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutUsDto;
using HotelProject.WebUI.Dtos.BookingDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.ServiceDto;
using HotelProject.WebUI.Dtos.StaffDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using HotelProject.WebUI.Dtos.TestimonialDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<RoomResultDto, Room>().ReverseMap();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();
            CreateMap<AddRoomDto, Room>().ReverseMap();

            CreateMap<StaffResultDto, Staff>().ReverseMap();
            CreateMap<UpdateStaffDto, Staff>().ReverseMap();
            CreateMap<AddStaffDto, Staff>().ReverseMap();

            CreateMap<AddSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<UpdateSubscribeDto, Subscribe>().ReverseMap();
            CreateMap<SubscribeResultDto, Subscribe>().ReverseMap();


            CreateMap<AddTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
            CreateMap<TestimonialResultDto, Testimonial>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();

            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<AboutUsResultDto,AboutUs>().ReverseMap();

            CreateMap<BookingCreateDto, Booking>().ReverseMap();
            CreateMap<BookingResultDto,Booking>().ReverseMap();

        }
    }
}
