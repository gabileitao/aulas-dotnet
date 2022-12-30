using System;
using System.Data;
using System.Data.SqlClient;

namespace BancoDeDados {

    public static class Program {
        public static void Main(string[] args) {

            // criar a conexão
            string connectionString = @"Data Source=DESKTOP-NB9D4BG\MSSQLSERVER01;Initial Catalog=biblioteca; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);

            // conectar de fato
            Console.WriteLine(connection.State);
            connection.Open();
            Console.WriteLine(connection.State);

            // criar e rodar o comando sql
            string sqlCommand = @"
                INSERT INTO autor (id, nome, nascimento, falecimento)
                VALUES (1, 'Nome Do Autor', '199-05-08', null)
            ";
            SqlCommand command = new SqlCommand(sqlCommand, connection);
            int affectedLines = command.ExecuteNonQuery();
            Console.WriteLine($"{affectedLines} linhas afetadas");


        }

    }

}