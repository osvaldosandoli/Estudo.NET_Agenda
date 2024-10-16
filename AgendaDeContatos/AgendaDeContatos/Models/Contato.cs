using System.ComponentModel.DataAnnotations;

namespace AgendaDeContatos.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Telefone é obrigatório")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; }
    }
}
