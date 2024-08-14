using System.ComponentModel.DataAnnotations;

namespace TesteDotNetInfinity.Models;

public class ListadeEntregas
{

    [Key]
    public int Id { get; set; }
    public required string Peso { get; set; }

    public required string Distancia { get; set; }

    public required string Empresa { get; set; }

    public required string Remetente { get; set; }

}