using System;

namespace _32.ForEWhile {
    class Program {
        static void Main(string[] args) {

            for (int contador1 = 0; contador1 <= 10; contador1++) {
                Console.WriteLine(contador1);
            }

            // =================================

            int contador2 = 0;
            while (contador2 <= 10) {
                Console.WriteLine(contador2);
                contador2++;
            }
            
            // =================================
            
            int contador3 = 0;
            bool ativo = true;
            while (ativo) {
                Console.WriteLine(contador3);
                if (contador3 == 5) {
                    ativo = false;
                }                
                contador3++;
            }
        }
    }
}
