using System;
using System.Collections.Generic;

namespace _37.FindArrayValueVExt {
    class Program {
        static void Main(string[] args) {
            int[] array = new[] { 4, 34, 73, 98, 100, 23, 7, 88, 999, 10, 100, 7, 88, 34, 100, 100, 33, 46, 4 };

            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            bool encontrei = false;
            List<int> indices = new List<int>();

            for (int i = 0; i < array.Length; i++) {
                if (n == array[i]) {
                    indices.Add(i);
                    encontrei = true;
                }
            }

            if (!encontrei) {
                Console.WriteLine("Não encontrei.");
            } else {
                Console.WriteLine($"Encontrei seu número na posição {string.Join(" | " , indices)}.");
            }
        }
    }
}
