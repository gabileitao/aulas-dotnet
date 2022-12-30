using System;

namespace _64.Interface {
    class Program {
        static void Main(string[] args) {

            Cachorro cachorro1 = new Cachorro();
            Gato gato1 = new Gato();

            Console.WriteLine($"{cachorro1.EmitirSom()} e {cachorro1.MarcarTerritorio()}");
            Console.WriteLine($"{gato1.EmitirSom()} e {gato1.MarcarTerritorio()}");

        }
    }
}
