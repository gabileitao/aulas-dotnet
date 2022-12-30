using System;

namespace While {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[] { 14, 24, 34, 44, 54, 64, 74, 84, 94, 104 };

            int i = 0;
            while (i < array.Length) {             
                Console.WriteLine(array[i]);
                i++;
            }
        }
    }
}
