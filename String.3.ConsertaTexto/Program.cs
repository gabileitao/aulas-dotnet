using System;

namespace String._3.ConsertaTexto {
    class Program {
        static void Main(string[] args) {

            string entrada = @"E o dod% disse: O mel$o! O mel$o, o mel$o, o mel$o!";
            string entradaCorrigida = entrada.Replace("%", "ô").Replace("$", "ã");

            Console.WriteLine(entrada);
            Console.WriteLine(entradaCorrigida);
        }
    }
}
