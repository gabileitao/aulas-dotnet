using System;

namespace _23.NumeroPrimo {
    class Program {
        static int getInput(string msg) {
            bool deubom = false;
            int numero = 0;
            while (deubom == false) {
                Console.Write(msg);
                string entrada = Console.ReadLine();
                deubom = int.TryParse(entrada, out numero);
                if (!deubom) {
                    Console.WriteLine("Entrada inválida.");
                }
            }
            return numero;
        }

        static void Main(string[] args) {
            int n = getInput("Escolha um número: ");

            bool isPrimo = true; // é primo até que seja provado o contrário

            for (int i = 2; i <= n - 1; i++) {
                if (n % i == 0) {
                    isPrimo = false;
                }
            }

            if (isPrimo) {
                Console.WriteLine("é primo");
            } else {
                Console.WriteLine("não é primo");
            }

        }
    }
}
