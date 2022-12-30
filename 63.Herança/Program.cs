using System;

namespace _63.Herança {
    class Program {
        static void Main(string[] args) {

            Gato gato1 = new Gato();
            gato1.CorDoPelo = "laranja";
            gato1.Limpo = false;
            gato1.Ronronar();

            Cachorro cachorro1 = new Cachorro();
            cachorro1.CorDoPelo = "branco";
            cachorro1.Limpo = false;

            Console.WriteLine($"O gato faz {gato1.EmitirSom()}");
            Console.WriteLine($"O cachorro faz {cachorro1.EmitirSom()}");

            Console.WriteLine($"O gato está {gato1.Limpo}.");
            Console.WriteLine($"O cachorro está {cachorro1.Limpo}.");

            DarBanho(gato1);
            DarBanho(cachorro1);

            Console.WriteLine($"O gato está {gato1.Limpo}.");
            Console.WriteLine($"O cachorro está {cachorro1.Limpo}.");

        }
        static void DarBanho(Animal animal) {

            animal.Limpo = true;

        }
    }
}
