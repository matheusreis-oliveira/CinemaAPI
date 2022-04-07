using AutoMapper;
using CinemaAPI.Data.Dtos;
using CinemaAPI.Models;

namespace CinemaAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, CinemaModel>();
            CreateMap<CinemaModel, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, CinemaModel>();
        }
    }
}
