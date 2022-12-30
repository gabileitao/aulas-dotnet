using System;

namespace _22.Fibonacci {
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

        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89

        static int fibonacci(int entrada) {

            int fibo = 1;
            int anterior = 0;

            Console.WriteLine(1);

            for (int i = 1; i <= entrada; i++) {
                int aux = anterior;
                anterior = fibo;
                fibo += aux;
                Console.WriteLine("{0}", fibo);
            }

            return fibo;

        }

        static void Main(string[] args) {
            int numero1 = getInput("Digite um número: ");

            int fib = fibonacci(numero1);

            Console.WriteLine(fib);
        }
    }
}
