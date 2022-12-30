using System;

namespace _08.Media {
    class Program {
        static float getInput(string msg) {
            Console.Write(msg);
            string entrada = Console.ReadLine();
            float n = float.Parse(entrada);
            return n;
        }
        static void Main(string[] args) {

            float n1 = getInput("Nota do 1º bimestre: ");
            float n2 = getInput("Nota do 2º bimestre: ");
            float n3 = getInput("Nota do 3º bimestre: ");
            float n4 = getInput("Nota do 4º bimestre: ");

            float media = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine($"Sua nota foi {media}.");

            if (media >= 5) {
                if (media == 10) {
                    Console.WriteLine("Você tirou um MB.");
                } else if (media < 10 && media >= 8) {
                    Console.WriteLine("Você tirou um B.");
                } else if (media < 8 && media >= 5) {
                    Console.WriteLine("Você tirou um R.");
                }
            } else {
                Console.WriteLine("Você tirou um I.");
            }
        }
    }
}
