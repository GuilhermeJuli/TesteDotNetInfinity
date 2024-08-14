

using Microsoft.Data.SqlClient;
using TesteDotNetInfinity.Database;
using TesteDotNetInfinity.Models;

public class FreteRepo
{

    private readonly string _coneectionString;
    public FreteRepo(string coneectionString)
    {
        _coneectionString = coneectionString;
    }

    public async Task AddFreteAsync(CadastroFrete frete)
    {
        using (var connection = new SqlConnection(_coneectionString)){
            connection.Open();
            var sql = 
            "INSERT INTO CadastroFrete (Origem, Destino, Distancia, , Peso, Status, UsuarioId, VeiculoId) VALUES (@Origem, @Destino, @Distancia, @VeiculoId, @Peso, @Status, @UsuarioId)";
            var command = new SqlCommand(sql, connection);
           
            command.Parameters.AddWithValue("@Origem", frete.Origem);
           
            command.Parameters.AddWithValue("@Destino", frete.Destino);
           
            command.Parameters.AddWithValue("@Distancia", frete.Distancia);

            command.Parameters.AddWithValue("@Peso", frete.Peso);
           
            command.Parameters.AddWithValue("@Status", frete.Status);        
           
            command.Parameters.AddWithValue("@VeiculoId", frete.VeiculoId);
           
            command.Parameters.AddWithValue("@UsuarioId", frete.Id);
           
            await command.ExecuteNonQueryAsync();
        }
    }
}