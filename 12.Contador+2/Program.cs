using System;

namespace _12.Contador_2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número positivo: ");
            string nEntrada = Console.ReadLine();
            int n = int.Parse(nEntrada);

            for (int i = 0; i <= n; i += 2) {
                Console.WriteLine(i);
            }
        }
    }
}
