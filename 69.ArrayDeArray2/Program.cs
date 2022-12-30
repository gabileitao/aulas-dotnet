using System;

namespace _69.ArrayDeArray2 {
    class Program {
        static void Main(string[] args) {

            Random random = new Random();

            int[][] array = new int[10][];

            for (int i = 0; i < array.Length; i++) {

                array[i] = new int[random.Next(5,10)];

                for(int j = 0; j < array[i].Length; j++) {
                    array[i][j] = random.Next(10,20);
                }
            }

            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    Console.Write($"{array[i][j]}, ");
                }
                Console.WriteLine();
            }

        }
    }
}
