using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Array {
    class Program {
        static void Main(string[] args) {
            //ARRAYS

            int[] numeros = new int[3];

            numeros[0] = 123;
            numeros[1] = 456;
            numeros[2] = 789;

            //Console.WriteLine($"Valor: {numeros[1]}");

            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine($"Posição {i}: {numeros[i]}");
            }

            //string s1 = "abcde";
            //char[] s2 = new char[] { 'a', 'b', 'c', 'd', 'e' };

            //Console.WriteLine(s1[1]);

        }
    }
}
