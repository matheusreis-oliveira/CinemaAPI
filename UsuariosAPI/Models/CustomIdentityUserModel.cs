using Microsoft.AspNetCore.Identity;
using System;

namespace UsuariosApi.Models
{
    public class CustomIdentityUserModel : IdentityUser<int>
    {
        public DateTime DataNascimento { get; set; }
    }
}
