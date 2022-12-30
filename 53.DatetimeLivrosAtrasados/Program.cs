using System;

namespace _53.DatetimeLivrosAtrasados {
    class Program {
        static void Main(string[] args) {
            //Descobrir se um livro está atrasado ou não.

            Livro[] livros = new Livro[] {
                new Livro("O Clone", new DateTime(2022, 01, 12)),
                new Livro("Perdidos no Espaço", new DateTime(2022, 03, 04)),
                new Livro("Holiday", new DateTime(2021, 06, 25)),
                new Livro("Grinch", new DateTime(2021, 02, 05)),
                new Livro("Looney Tunes", new DateTime(2021, 10, 12)),
                new Livro("Reaping", new DateTime(2021, 12, 10)),
                new Livro("Disney", new DateTime(2022, 02, 15)),
                new Livro("Oswaldo", new DateTime(2021, 06, 25)),
                new Livro("Chaves", new DateTime(2022, 01, 13)),
                new Livro("MBL", new DateTime(2022, 03, 01)),
            };

            int limiteAluguelEmMeses = 60;
            DateTime entrega = DateTime.Now;

            for (int i = 0; i < livros.Length; i++) {
                TimeSpan intervalo = entrega - livros[i].DataAluguel;
                if (intervalo.TotalDays <= limiteAluguelEmMeses) {
                    Console.WriteLine(livros[i].Titulo + " está em dia." + $" Você está há {(int)intervalo.TotalDays} com o livro.");
                } else {
                    Console.WriteLine(livros[i].Titulo + " está atrasado. Devolver imediatamente." + $" O livro está atrasado há {(int)intervalo.TotalDays} atrasado.");
                }
            }
        }
    }
}
