using System;

namespace Operadores {
    class Program {
        static void Main(string[] args) {

            // operadores aritméticos:
            // + - * / %

            // operadores comparação:
            // < > == <= >= !=

            bool sucesso = true;

            if (!sucesso) {
                Console.WriteLine("Fracasso");
            }

            // operadores lógicos:
            // && || ^^(não muito usado) 

            // operadores de atribuição:
            // = += -= *= /= %= ++ --

            int n = 2;

            n = n + 2;

            n += 2;

            n++;
            n--;

            Console.WriteLine(n);

            // operadores binários:
            // & | ^ << >>

        }
    }
}
