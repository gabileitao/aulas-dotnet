using System;

namespace _29._ArrayTamanhoVariavel {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o tamanho do 'array': ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] n = new int[tamanho];

            for (int i = 0; i < n.Length; i++) {
                Console.Write($"Digite o valore da posição {i}: ");
                n[i] = int.Parse(Console.ReadLine());
                //n[i] = valorInt;
            }

            for (int i = 0; i < n.Length; i++) {
                Console.WriteLine($"Seus valores: {n[i]}.");
            }
        }
    }
}
