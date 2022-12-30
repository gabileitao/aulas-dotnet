using System;

namespace WhileInput {
    class Program {
        static void Main(string[] args) {

            //string nome = "";

            //while (nome.ToLower() != "maria" ) {
            //    Console.WriteLine("Escreva um nome: ");
            //    nome = Console.ReadLine();
            //}

            bool maria = false;

            while (!maria) {
                Console.WriteLine("Escreva um nome: ");
                string  nome = Console.ReadLine();
                //if (nome.ToLower() == "maria") {
                //    maria = true;
                //} else {
                //    maria = false;
                //}
                //maria = nome.ToLower() == "maria" ? true : false;
                maria = nome.ToLower() == "maria";
            }
        }
    }
}
