using System;

namespace _52.DatetimeIdade {
    class Program {
        static void Main(string[] args) {
            //Usuário entra data de nascimento e o programa deve retornar a idade.

            Console.WriteLine("Digite a data de nascimento (YYYY-MM-DD): ");
            string entrada = Console.ReadLine();
            DateTime aniversario = DateTime.Parse(entrada);

            DateTime hoje = DateTime.Today;

            TimeSpan intervalo = hoje - aniversario;
            DateTime idade = new DateTime(intervalo.Ticks);
            //gambiarra

            Console.WriteLine(idade.Year - 1);

        }
    }
}
