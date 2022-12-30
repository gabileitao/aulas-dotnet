using System;
using System.Linq;

namespace _36.FindArrayValue {
    class Program {
        static void Main(string[] args) {

            //o usuário vai digitar um dos valores do array e o 
            //programa precisa mostrar na tela a posição dentro
            //do array.

            int[] array = new[] { 4, 34, 73, 98, 100, 23, 7, 88, 999, 10 };

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            bool encontrei = false;
            int indice = 0;

            for (int i = 0; i < array.Length; i++) {
                if (n == array[i]) {
                    indice = i;
                    encontrei = true;
                    break;
                }
            }

            if (!encontrei) {
                Console.WriteLine("Não encontrei.");
            } else {
                Console.WriteLine($"Encontrei seu número na posição {indice}.");
            }
        }
    }
}
