using System;

namespace _30.MaiorNumero {
    class Program {
        static void Main(string[] args) {
            int[] num = new int[5];
            int maior = int.MinValue;

            for (int i = 0; i < num.Length; i++) {
                Console.WriteLine($"Digite o valor da posição {i}: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++) {
                if (num[i] >= maior) {
                    maior = num[i];
                }
            }

            Console.WriteLine($"O maior é {maior}.");
        }
    }
}
