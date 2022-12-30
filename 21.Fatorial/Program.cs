using System;

namespace _21.Fatorial {
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

        //4! = 4 * 3 * 2 * 1 = 24

        static int fatorial(int entrada) {

            int fat = 1;
            for (int i = entrada; i >= 1; i--) {
                fat *= i;
            }
            return fat;
        }

        static void Main(string[] args) {
            int numero1 = getInput("Digite um número: ");

            int fat = fatorial(numero1);

            Console.WriteLine(fat);
        }
    }
}
