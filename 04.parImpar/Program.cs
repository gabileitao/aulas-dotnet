using System;

namespace _04.ParImpar {
    class Program {
        static void Main(string[] args) {
            int a = 53;
            //int resto = a % 2; //mod, é o resto da divisão.
            bool isPar = false;
            if (a % 2 == 0) {
                isPar = true;
                Console.WriteLine($"O valor {a} é par.");
            } else {
                isPar = false;
                Console.WriteLine($"O valor {a} é ímpar.");
            }
        }
    }
}
