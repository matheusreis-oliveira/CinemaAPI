using AutoMapper;
using CinemaAPI.Data.Dtos;
using CinemaAPI.Models;

namespace CinemaAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, FilmeModel>();
            CreateMap<FilmeModel, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, FilmeModel>();
        }
    }
}