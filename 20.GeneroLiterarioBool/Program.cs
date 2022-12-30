using System;

namespace _20.GeneroLiterarioBool {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Um gênero literário para você.");
            Console.WriteLine("Responda as perguntas com 'S' para sim e 'N' para não.");

            Console.WriteLine("Você gosta da realidade?");
            string entradaUm = Console.ReadLine();
            char realChar = char.Parse(entradaUm);

            bool real = realChar == 'S' || realChar == 's';

            Console.WriteLine("Você gosta de se emocionar?");
            string entradaDois = Console.ReadLine();
            char emotionalChar = char.Parse(entradaDois);

            bool emotional = emotionalChar == 'S' || emotionalChar == 's';

            Console.WriteLine("Você gosta de ter surpresas?");
            string entradaTrês = Console.ReadLine();
            char surp = char.Parse(entradaTrês);

            bool surprise = surp == 'S' || surp == 's';

            if (real && emotional && surprise) {
                Console.WriteLine("Ótimo! Você pode ler tanto Fantasia, quanto Drama, Terror/Suspense e Policial!");
            } else if (!real && !emotional && surprise) {
                Console.WriteLine("Você poderia ler Fantasia.");
            } else if (real && emotional && !surprise) {
                Console.WriteLine("Você poderia ler Drama.");
            } else if (!real && emotional && surprise) {
                Console.WriteLine("Você deveria ler Terror/Suspense.");
            } else if (real && !emotional && surprise) {
                Console.WriteLine("Você poderia ler Policial.");
            } else {
                Console.WriteLine("Não gosta de nada? Seria legal repensar suas respostas!");
            }
        }
    }
}
