using System;

namespace _34.ValidacaoEntradaFuncoes {
    class Program {
        static void Main(string[] args) {
            int n1 = GetInputInteger();
            int n2 = GetInputInteger();

            Console.WriteLine(n1 + n2);
        }

        static int GetInputInteger() {
            bool converteu = false;
            int numero = 0;
            while (!converteu) {
                Console.WriteLine("Digite um número: ");
                string entrada = Console.ReadLine();
                converteu = int.TryParse(entrada, out numero);
                if (!converteu) {
                    Console.WriteLine("Entrada Inválida.");
                }
            }
            return numero;
        }
    }
}
