using System;

namespace _68.ArrayDeArray {
    class Program {
        static void Main(string[] args) {

            Random random = new Random();

            //random.Next() -> para criar números aleatórios.

            int[] array = new int[10];

            for(int i = 0; i < array.Length; i++) {
                array[i] = random.Next();
            }

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }

        }
    }
}
