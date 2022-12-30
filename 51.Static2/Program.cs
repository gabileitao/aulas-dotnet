using System;

namespace _51.Static2 {
    class Program {
        static void Main(string[] args) {
            Pokemon p1 = new Pokemon();
            p1.Nome = "pikachu";

            Pokemon p2 = new Pokemon();
            p2.Nome = "tentacruel";

            Pokemon p3 = DayCare.Breed(p1, p2);

            Console.WriteLine(p3.Nome);

        }
    }
}
