using System;
using System.ComponentModel.DataAnnotations;

namespace CinemaAPI.Models
{
    public class FilmeModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo de título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo de duração é obrigatório")]
        [Range(1, 600, ErrorMessage = "A duração deve ter no mínimo 1 minuto e no máximo 600 minutos (10 horas).")]
        public int Duracao { get; set; }
        [StringLength(100, ErrorMessage = "O nome do diretor não pode exceder 100 caracteres")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
    }
}