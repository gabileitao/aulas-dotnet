using System;

namespace _16.WhileInput {
    class Program {
        static void Main(string[] args) {
            string abc = "abc";

            while (abc != "abc") {
                Console.WriteLine(@"Digite ""abc"": ");
                abc = Console.ReadLine();
            }

            Console.WriteLine("Xuxesso!");
        }
    }
}
