using System;

namespace _14.Tabuadas {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número positivo: ");
            string nEntrada = Console.ReadLine();
            int numeroTabuadas = int.Parse(nEntrada);

            for (int tabuadaAtual = 1; tabuadaAtual <= numeroTabuadas; tabuadaAtual++) {
                for (int i = 1; i <= 10; i++) {
                    Console.WriteLine($"{i} * {tabuadaAtual} = {i * tabuadaAtual}");
                }
            }
        }
    }
}
