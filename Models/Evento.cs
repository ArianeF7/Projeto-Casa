using System;
using System.ComponentModel.DataAnnotations;

namespace CasaDeShow1.Models
{
    public class Evento
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A capacidade maxima do evento é obrigatória")]
        [Display(Name = "Capacidade")]
        public int Capacidade { get; set; }

        [Required(ErrorMessage = "O preço unitário do ingresso é obrigatório")]
        public float preco { get; set; }

        [Required(ErrorMessage = "A categoria/gênero do evento é obrigatório")]
        public string categoria { get; set; }


        [Required(ErrorMessage = "a data do evento é obrigatória")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O local do evento é obrigatório")]
        public Local Local { get; set; }
    }
}
