using System;
using System.Linq;

namespace _54.Contains {
    class Program {
        static void Main(string[] args) {

            //Contains funciona como o like do sql, mas aqui serve tanto para
            //string/char quanto para array.

            string frase = "Chupa cu de Kiev";

            if (frase.Contains("Kiev")) {
                Console.WriteLine("Está presente.");
            }

            int[] random = new int[] { 1, 23, 5, 666, 19, -9, -5, 1/3 };

            if (random.Contains(19)) {
                Console.WriteLine("Está presente.");
            }
        }
    }
}
