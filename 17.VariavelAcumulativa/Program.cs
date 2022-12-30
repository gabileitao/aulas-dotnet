using System;

namespace _17.VariavelAcumulativa {
    class Program {
        static void Main(string[] args) {
            int soma = 0;

            for (int i = 1; i <= 10; i++) {
                soma += i;
            }

            Console.WriteLine(soma);
        }
    }
}
