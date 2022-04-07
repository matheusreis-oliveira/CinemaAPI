using AutoMapper;
using CinemaAPI.Models;
using CinemaAPI.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaAPI.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, EnderecoModel>();
            CreateMap<EnderecoModel, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, EnderecoModel>();
        }
    }
}
