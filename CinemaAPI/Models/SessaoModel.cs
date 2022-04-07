﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CinemaAPI.Models
{
    public class SessaoModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual CinemaModel Cinema { get; set; }
        public virtual FilmeModel Filme { get; set; }
        public int FilmeId { get; set; }
        public int CinemaId { get; set; }
        public DateTime HorarioDeEncerramento { get; set; }
    }
}
