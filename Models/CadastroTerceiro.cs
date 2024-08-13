using System.ComponentModel.DataAnnotations;

namespace TesteDotNetInfinity.Models;

   public class CadastroTerceiro{

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome do terceiro é obrigatório")]
        [StringLength(30, ErrorMessage = "O nome do terceiro não pode ter mais de 30 caracteres")]
        public required string NomeTerceiro { get; set; }

        [Required(ErrorMessage ="A descrição do veiculo é obrigatória.")]
        [Range(1, 30, ErrorMessage = "A descrição do veiculo deve ter entre 1 e 30 caracteres")]
        public required string DescricaodoVeiculo { get; set; }

        [Required(ErrorMessage ="A placa do veiculo é obrigatória.")]
        [StringLength(8, ErrorMessage = "A placa do veiculo deve ter 8 caracteres")]
        public required string PlacaVeiculo { get; set; }

        [Required(ErrorMessage ="O tipo do veiculo é obrigatório")]
        [StringLength(30, ErrorMessage = "O tipo do veiculo deve ter entre 1 e 30 caracteres")]
        public required string Tipo { get; set; }
    }