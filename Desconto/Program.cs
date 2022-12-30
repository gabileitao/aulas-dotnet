using System;
using System.Globalization;

namespace Desconto {
    class Program {
        static void Main(string[] args) {
            //E1P em que o usuário digita o valor do produto,
            //uma porcentagem de desconto e o programa tem
            //que mostrar o valor com o desconto aplicado.
            //Requisitos do programa: o usuário tem que usar '.'
            //e não ','; e a porcentagem é o valor inteiro, não quebrado.


            float produto = GetFloatNumber("Digite o preço do produto: ");

            int porcentagem = GetIntNumber("Agora, digite a porcentagem do produto: ");

            float valorFinal = produto - ((produto * porcentagem)/100);

            Console.WriteLine(valorFinal);

        }

        static float GetFloatNumber(string msg) {
            bool number = false;
            float valor = 0;

            while (!number) {
                Console.WriteLine(msg);
                string entrada = Console.ReadLine();
                number = float.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out valor);

                if (!number) {
                    Console.WriteLine("Entrada inválida, digite um número!");
                }
            }

            //while (!number) {
            //    Console.WriteLine(msg);
            //    try {
            //        valor = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //        number = true;
            //    } catch {
            //        Console.WriteLine("Entrada inválida, digite um número!");
            //        number = false;
            //    }
            //}


            return valor;
        }

        static int GetIntNumber (string msg) {
            bool number = false;
            int valor = 0;
            
            while (!number) {
                Console.WriteLine(msg);
                string entrada = Console.ReadLine();
                number = int.TryParse(entrada ,out valor);

                if (!number) {
                    Console.WriteLine("Entrada inválida, digite um número!");
                }
            }

            return valor;
        }

    }
}
