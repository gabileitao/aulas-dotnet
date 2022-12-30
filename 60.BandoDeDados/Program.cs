using System;
using System.Data.SqlClient;

namespace _60.BandoDeDados {
    class Program {
        static void Main(string[] args) {

            //mostra os parâmetros para conectar no servidor.
            string connectionString = "Data Source=localhost;Initial Catalog=biblioteca;Integrated Security=True;Connect Timeout=1;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //instância a SqlConnection para criar a conexão com o servidor.
            SqlConnection connection = new SqlConnection(connectionString);

            try {
                //Inicia a conexão, é sempre obrigatório existir.
                connection.Open();

                //Passar o id na mão, é ruim, deveríamos usar o auto incremente do BD.
                string insertText = "insert into autor (id, nome, nascimento, falecimento) values (999, 'abc', '1980-06-24', null)";

                //instância a SqlCommand para criar a query/comando.
                SqlCommand command = new SqlCommand(insertText, connection);

                //Serve para executar a query inserida no código e rodá-la no BD. Seu retorno serve para saber se a query funcionou.
                int affectedLines = command.ExecuteNonQuery(); 

                if (affectedLines > 0) {
                    Console.WriteLine("Inserido com sucesso!");
                } else {
                    Console.WriteLine("Nenhum registro inserido.");
                }

            } catch (Exception e) {
                Console.WriteLine("=========================================");
                Console.WriteLine("DEU BOSTA");
                Console.WriteLine("-----------------------------------------");
                
                //mostra na tela preta quais foram os erros que criaram essa exception.
                Console.WriteLine(e.Message);
                Console.WriteLine("=========================================");

            } finally {
                //Fecha a conexão, é sempre obrigatório existir.
                connection.Close();
            }
        }
    }
}
