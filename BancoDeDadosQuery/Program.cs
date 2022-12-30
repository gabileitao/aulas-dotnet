using System;
using System.Data.SqlClient;

namespace BancoDeDadosQuery {
    class Program {
        static void Main(string[] args) {
            
            string connectionString = @"Data Source=DESKTOP-NB9D4BG\MSSQLSERVER01;Initial Catalog=biblioteca; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string selectCommand = "select * from autor where falecimento is not null";
            
            SqlCommand command = new SqlCommand(selectCommand, connection);

            SqlDataReader reader = command.ExecuteReader();

            //comandos para mostrar o resultado do dataset

            //// ir para a linha 1
            //Console.WriteLine(reader.Read());
            //int id = reader.GetInt32(0);
            //string nome = reader.GetString(1);
            //Console.WriteLine(id);
            //Console.WriteLine(nome);

            //// ir para a linha 2
            //Console.WriteLine(reader.Read());
            //id = reader.GetInt32(0);
            //nome = reader.GetString(1);
            //Console.WriteLine(id);
            //Console.WriteLine(nome);

            //// ir para a linha 3
            //Console.WriteLine(reader.Read());
            //id = reader.GetInt32(0);
            //nome = reader.GetString(1);
            //Console.WriteLine(id);
            //Console.WriteLine(nome);

            //// ir para a linha 4
            //Console.WriteLine(reader.Read());
            //id = reader.GetInt32(0);
            //nome = reader.GetString(1);
            //Console.WriteLine(id);
            //Console.WriteLine(nome);

            //// ir para a linha 5
            //Console.WriteLine(reader.Read());
            //id = reader.GetInt32(0);
            //nome = reader.GetString(1);
            //Console.WriteLine(id);
            //Console.WriteLine(nome);

            ////vai retornar false, não existe linha 6
            //Console.WriteLine(reader.Read());
            
            while(reader.Read()) {
                int id = reader.GetInt32(0);
                string nome = reader.GetString(1);
                Console.WriteLine(id);
                Console.WriteLine(nome);
            }

            reader.Close();
            connection.Close();
        }
    }
}
