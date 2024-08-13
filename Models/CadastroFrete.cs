using System.ComponentModel.DataAnnotations;

namespace TesteDotNetInfinity.Models
{
    public class CadastroFrete
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="O nome da empresa é obrigatório")]
        [StringLength(30, ErrorMessage = "O nome da empresa não pode ter mais de 30 caracteres", MinimumLength = 2)]
        public required string NomedaEmpresa { get; set; }
        
        [Required(ErrorMessage ="O nome do destinatário é obrigatório")]
        [StringLength(30, ErrorMessage = "O nome do destinatário não pode ter mais de 30 caracteres", MinimumLength = 2)]
        public required string NomeDestinatario { get; set; }

        [Required(ErrorMessage ="A distancia do frete é obrigatória.")]
        [Range(1, 1000, ErrorMessage = "A distancia do frete deve ser entre 1km e 1000km")]
        public int Distancia { get; set; }

    }

 
}