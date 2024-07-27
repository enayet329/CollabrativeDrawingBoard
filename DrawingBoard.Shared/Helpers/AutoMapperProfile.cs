using AutoMapper;
using DrawingBoard.Core.Entities;
using DrawingBoard.Shared.DTOs;


namespace DrawingBoard.Shared.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Board, BoardDto>().ReverseMap();
            CreateMap<Drawing, DrawingDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
