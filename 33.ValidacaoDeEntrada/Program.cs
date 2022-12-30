using System;

namespace _33.ValidacaoDeEntrada {
    class Program {

        /*
            1º Validar se o usuário digitou um int válido;
            Caso a entrada não for um int válido, pedir
            para o usuário repetir.
         */

        static void Main(string[] args) {
            bool converteu = false;
            int numero;
            while (!converteu) {
                Console.WriteLine("Digite um número: ");
                string entrada = Console.ReadLine();
                converteu = int.TryParse(entrada, out numero);
                if (!converteu) {
                    Console.WriteLine("Entrada Inválida.");
                }
            }
            //return numero;
        }
    }
}
