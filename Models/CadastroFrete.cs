using System.ComponentModel.DataAnnotations;

namespace TesteDotNetInfinity.Models
{
        public class CadastroFrete
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "A origem é obrigatória")]
        [StringLength(255, ErrorMessage = "A origem não pode ter mais de 255 caracteres")]
        public required string Origem { get; set; }

        [Required(ErrorMessage = "O destino é obrigatório")]
        [StringLength(255, ErrorMessage = "O destino não pode ter mais de 255 caracteres")]
        public required string Destino { get; set; }

        [Required(ErrorMessage = "A distância é obrigatória")]
        [Range(1, 1000, ErrorMessage = "A distância deve estar entre 1 e 1000 km")]
        public required decimal Distancia { get; set; }

        [Required(ErrorMessage = "O peso é obrigatório")]
        [Range(0.01, 10000, ErrorMessage = "O peso deve ser maior que 0 e até 10.000")]
        public required decimal Peso { get; set; }

        [Required(ErrorMessage = "O status é obrigatório")]
        [StringLength(50, ErrorMessage = "O status não pode ter mais de 50 caracteres")]
        public required string Status { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório")]
        public required int UsuarioId { get; set; }

        [Required(ErrorMessage = "O ID do veículo é obrigatório")]
        public required int VeiculoId { get; set; }

        public DateTime DataDeCadastro { get; set; } = DateTime.Now;

        public DateTime? DataDeFinalizacao { get; set; }
    }
}


