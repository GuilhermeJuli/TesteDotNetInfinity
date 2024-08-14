using System.ComponentModel.DataAnnotations;

namespace TesteDotNetInfinity.Models;

   public class CadastroVeiculos{
    [Key]
    public int Id { get; set; }


    [Required(ErrorMessage = "O campo {0} e obrigatorio")]
    [StringLength(30, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Placa { get; set; }


    [Required(ErrorMessage = "O campo {0} e obrigatorio")]
    [StringLength(30, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 2)]
    public string Modelo { get; set; }


    [Required(ErrorMessage = "O campo {0} e obrigatorio")]
    public int Ano { get; set; }


    [Required(ErrorMessage = "O campo {0} e obrigatorio")]
    public decimal Capacidade { get; set; }


    [Required(ErrorMessage = "O campo {0} e obrigatorio")]
    public DateTime DataDeCadastro { get; set; }

    }