using System;

namespace _41.Classes {
    class Program {
        static void Main(string[] args) {

            Cachorro c1 = new Cachorro();
            c1.Nome = "Shade";
            c1.Altura = 1.61f;
            c1.Cor = "Preto e Marrom";
            c1.Peso = 30;
            c1.Raca = "Pastor alemão";

            Console.WriteLine($"{c1.Nome} é um cachorro da raça {c1.Raca}, que pesa {c1.Peso} e tem {c1.Altura}m de altura. Suas cores são: {c1.Cor}.");

            Cachorro c2 = new Cachorro();
            c2.Nome = "Blitz";
            c2.Altura = 1.70f;
            c2.Cor = "Branco";
            c2.Peso = 45;
            c2.Raca = "Dogue Alemão";

            Console.WriteLine($"{c2.Nome} é um cachorro da raça {c2.Raca}, que pesa {c2.Peso.ToString("#.00")} e tem {c2.Altura.ToString("#.00")}m de altura. Suas cores são: {c2.Cor}.");

        }
    }
}
