using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace API1.Controllers {

    public class CalculadoraController : ApiController {

        [HttpGet, Route("calculadora/somar/{n1:int}/{n2:int}")]
        public int Somar([FromUri]int n1, [FromUri]int n2) {

            int resultado = n1 + n2;

            return resultado;
        }

        [HttpGet, Route("autor")]
        public IEnumerable<string> GetAutor() {
            var builder = new SqlConnectionStringBuilder();
            builder.InitialCatalog = "biblioteca";
            builder.DataSource = "localhost";
            builder.IntegratedSecurity = true;
            var connectionString = builder.ToString();
            using (var connection = new SqlConnection(connectionString)) {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM autor";
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        yield return $"ID = {reader.GetInt32(0)}, NOME = {reader.GetString(1)}";
                    }
                }
            }
        }

    }

}