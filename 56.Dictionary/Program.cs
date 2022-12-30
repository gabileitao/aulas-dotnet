using System;
using System.Collections.Generic;
using System.Linq;

namespace _56.DictionaryAula {
    class Program {
        static void Main(string[] args) {
            //Dictionary foi criado para ser um array em que você escolhe o tipo do índice.
            //Key-value (chave-valor) pair. Internamente, ele é um array de "key-value pair".
            //.Count é equivalente ao .Lenght de um array normal.

            Dictionary<string, string> bichos = new Dictionary<string, string>();
            bichos["shade"] = "cachorro";
            bichos["alemao"] = "gato";
            bichos["pitu"] = "peste";

            //Console.WriteLine(bichos["shade"]);

            for(int i = 0; i < bichos.Count; i++) {
                Console.WriteLine(bichos.Keys.ToArray()[i] + " = " + bichos.Values.ToArray()[i]);
            }
        }
    }
}
