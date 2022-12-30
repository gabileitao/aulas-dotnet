using System;
using System.Globalization;

namespace _09.Funcao {
    class Program {

        static void Main(string[] args) {

            Console.WriteLine("Digite a nota: ");
            float nota = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string mencao = NotaToMencao(nota);
            Console.WriteLine($"A nota do Joãozinho foi {mencao}.");

        }

        static string NotaToMencao(float nota) {
            if (nota < 5) {
                return "I";
            } else if (nota >= 5 && nota < 7) {
                return "R";
            } else if (nota >= 7 && nota < 9) {
                return "B";
            } else {
                return "MB";
            }
        }

    }
}
