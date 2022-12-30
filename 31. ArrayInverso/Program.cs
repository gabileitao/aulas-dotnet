using System;
using System.Linq;

namespace _31._ArrayInverso {
    class Program {
        static void Main(string[] args) {
            //Pedir tamanho do Array; pedir para o usuário encher o array. Depois criar outro array e colocar os valores invertidos.

            Console.WriteLine("Digite o tamanho do array: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] aUm = new int[tamanho];

            for (int i = 0; i < aUm.Length; i++) {
                Console.WriteLine($"Escolha um valor para a posição {i}: ");
                aUm[i] = int.Parse(Console.ReadLine());
            }

            int[] aDois = new int[tamanho];

            for (int i = 0; i < aUm.Length; i++) {
                aDois[aDois.Length - 1 - i] = aUm[i];
            }

            for (int i = 0; i < aDois.Length; i++) {
                Console.WriteLine(aDois[i]);
            }
        }
    }
}
