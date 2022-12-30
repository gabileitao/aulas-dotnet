using System;

namespace _24.TryParse {
    class Program {
        static void Main(string[] args) {
            string texto1 = "123";
            int numero1 = int.Parse(texto1);

            //string texto2 = "abc";
            //int numero2 = int.Parse(texto2);

            string texto3 = "abc";
            bool deubom = int.TryParse(texto3, out int numero3);

            if (deubom) {
                Console.WriteLine($"conseguiu converter, ta aqui ó {numero3}");
            } else {
                Console.WriteLine($"ta locao mano, isso aqui não é numero não brooo {texto3}");
            }
        }
    }
}
