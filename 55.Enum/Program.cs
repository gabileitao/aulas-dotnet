using System;

namespace _55.Enum {
    class Program {
        static void Main(string[] args) {
            //Enum não é um numerador (enumerator), nem um enumerável (enumerable);
            //É bom para quando você tem uma lista de algo e você não quer ficar 
            //definindo essas coisas como um texto.
            //
            //Ele nomeia números. É usado para travar a variável em um único valor, tipando ela.
            //Ele é um agrupador de constantes.

            //const int grass = 1;
            //const int fire = 2;

            Pokemon p1 = new Pokemon();
            p1.Nome = "Bulbasauro";
            p1.Tipo = Tipo.grass;

            Pokemon p2 = new Pokemon();
            p2.Nome = "Charmander";
            p2.Tipo = Tipo.fire;

            if (p1.Tipo == Tipo.grass) {
                Console.WriteLine($"{p1.Nome} é grama.");
            } else {
                Console.WriteLine($"{p1.Nome} não é grama.");
            }

            Tipo[] tipos = new Tipo[] { Tipo.fire, Tipo.fire, Tipo.water };

            for (int i = 0; i < tipos.Length; i++) {
                Console.WriteLine(tipos[i]);
            }

            for (int i = 0; i < tipos.Length; i++) {
                Console.WriteLine((int)tipos[i]);
            }
        }
    }
}
