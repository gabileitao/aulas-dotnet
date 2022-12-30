using System;

namespace _11.Contador {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite um número positivo: ");
            string nEntrada = Console.ReadLine();
            int n = int.Parse(nEntrada);

            for (int i = 0; i <= n; i++) {
                Console.WriteLine(i);
            }
        }
    }
}
