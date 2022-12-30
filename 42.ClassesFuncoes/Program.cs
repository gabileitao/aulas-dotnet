using System;

namespace _42.ClassesFuncoes {
    class Program {
        static void Main(string[] args) {
            Cachorro c1 = new Cachorro();
            c1.Nome = "Shade";
            c1.Altura = 1.61f;
            c1.Cor = "Preto e Marrom";
            c1.Peso = 30;
            c1.Raca = "Pastor alemão";

            Cachorro c2 = new Cachorro();
            c2.Nome = "Blitz";
            c2.Altura = 1.70f;
            c2.Cor = "Branco";
            c2.Peso = 45;
            c2.Raca = "Dogue Alemão";

            c1.Latir();
            c2.Latir();

            c1.MostrarInf();
            c2.MostrarInf();
            
        }
    }
}
