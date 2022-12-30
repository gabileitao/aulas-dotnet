using System;

namespace _19.ConsoleColor {
    class Program {
        static void Main(string[] args) {
            var r = new Random();
            int v = r.Next(1, 6);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(v);


            if (v <= 3) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pedro é cruel.");
            } else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ele pode ser bonzinho...");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
