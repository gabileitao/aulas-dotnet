using System;

namespace _13.Tabuada {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número positivo: ");
            string nEntrada = Console.ReadLine();
            int n = int.Parse(nEntrada);

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{i} * {n} = {i * n}");
            }
        }
    }
}
