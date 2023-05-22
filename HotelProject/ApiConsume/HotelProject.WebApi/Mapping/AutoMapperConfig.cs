using AutoMapper;
using HotelProject.DtoLayer.Room;
using HotelProject.EntityLayer.Concrete;
using System.ComponentModel.Design;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<AddRoomDto, Room>();
            CreateMap<Room, AddRoomDto>();

            CreateMap<UpdateRoomDto, Room>();
            CreateMap<Room, UpdateRoomDto>();

        }
    }
}
