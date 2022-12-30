using System;

namespace _61.TryCatchFinally {
    class Program {
        static void Main(string[] args) {

            //TryCatchFinally = se ter uma exception dentro do Try, ele cai dentro do Catch;
            //se não der uma exception no Try, ele não entra no Catch;
            //Se ele entrar no Catch, depois ele entra no Finally;
            //se ele não entrar no Catch, ele também entra no Finally.

            //Serve para garantir que o resto do código termine mesmo
            //que aconteça uma exception no início do código.
            //Exceção tratada;
            //Em banco de Dados é comum existirem exceções, assim como pode acontecer
            //em qualquer coisa que faça acesso com coisas fora do código.

            try {
                int a = int.Parse("cxzcz");
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            } finally {
                Console.WriteLine("Terminei de rodar.");
            }

        }
    }
}
