using System;
using System.Collections.Generic;

namespace _57.DictionaryFeriados {
    class Program {
        static void Main(string[] args) {

            var holidays = new Dictionary<DateTime, bool> {
                {new DateTime(2022, 12, 25), true },
                {new DateTime(2022, 05, 19), false },
                {new DateTime(2022, 01, 01), true },
                {new DateTime(2022, 01, 02), false },
            };

            if (holidays[new DateTime(2022, 12, 25)]) {
                Console.WriteLine("É feriado!");
            }

        }
    }
}
