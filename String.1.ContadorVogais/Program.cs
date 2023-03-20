using System;
using String.Utils;

namespace String._1.ContadorVogais {
    class Program {
        static void Main(string[] args) {

            string entrada = "Maria Gabriela de Souza Leitão";
            char[] chars = new char[] {'m', 'l', 'a'};

            int num = StringUtils.ContaCaracteres(entrada, chars);

            Console.WriteLine(num);
        }
    }
}
