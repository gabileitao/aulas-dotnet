using System;

namespace _05.ReadLine {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um valor: ");
            string entrada = Console.ReadLine();
            int numero = int.Parse(entrada);
            Console.Write($"Você digitou {numero * 2}.");
        }
    }
}
