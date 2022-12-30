using System;

namespace _50.DateTime2 {
    class Program {
        static void Main(string[] args) {

            DateTime dataNascimento = new DateTime(1996, 02, 15);

            DateTime dataAtual = DateTime.Now;

            //TimeSpan é uma quantidade de tempo. Qualquer operação feita com DateTime retorna um TimeSpan.
            TimeSpan diferenca = dataAtual - dataNascimento;

            //int idade = Convert.ToInt32(Math.Floor(diferenca.TotalDays / 365.0));

            int idade = (int)(diferenca.TotalDays / 365.0);

            Console.WriteLine(idade);

        }
    }
}
