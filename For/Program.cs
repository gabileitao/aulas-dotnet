using System;

namespace For {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[] { 14, 24, 34, 44, 54, 64, 74, 84, 94, 104 };

            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
        }
    }
}
