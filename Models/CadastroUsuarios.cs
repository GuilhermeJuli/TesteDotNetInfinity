using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TesteDotNetInfinity.Models
{
    public class CadastroUsuarios
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Perfil { get; set; }

        [Required]
        public DateTime DataDeCadastro { get; set; }
    }
}