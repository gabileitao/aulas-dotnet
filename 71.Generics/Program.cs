using System;

namespace _71.Generics {
    class Program {
        static void Main(string[] args) {

            //Caixa cx1 = new Caixa(10);

            //Console.WriteLine(cx1.Coisa);

            //int numero = 2;

            //object numero2 = "oi";

            //Console.WriteLine(numero2.GetType().Name);

            //numero2 = 5;

            //Console.WriteLine(numero2.GetType().Name);

            //todos os tipos, primitivos ou classes, todos herdam do tipo OBJECT.
            //nunca usar uma variável object, evitar ao máximo.

            Caixa<bool> c1 = new Caixa<bool>(true);

            Caixa<int> c2 = new Caixa<int>(10);

            var a = 123;

            Teste(123);


        }

        static void Teste<T> (T variavel) {
            
        } 

    }
}
