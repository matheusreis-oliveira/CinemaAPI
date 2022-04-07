using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, UsuarioModel>();
            CreateMap<UsuarioModel, IdentityUser<int>>();
            CreateMap<UsuarioModel, CustomIdentityUserModel>();
        }
    }
}
