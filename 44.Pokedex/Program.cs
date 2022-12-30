using System;

namespace _44.Pokedex {

    public class Program {

        public static void Main(string[] args) {

            Pokemon p1 = new Pokemon() { Id = 001, Nome = "Bulbasaur", TipoUm = "Grass", TipoDois = null };
            //inutil, mas exemplo do construtor default

            Pokemon[] pokedex = new Pokemon[] { 
                new Pokemon(001, "Bulbasaur", "Grass", null),
                new Pokemon(002, "Ivysaur", "Grass", null),
                new Pokemon(003, "Venusaur", "Grass", "Poison"),
                new Pokemon(004, "Charmander", "Fire", null),
                new Pokemon(005, "Charmeleon", "Fire", null),
                new Pokemon(006, "Charizard", "Fire", "Flying"),
                new Pokemon(007, "Squirtle", "Water", null),
                new Pokemon(008, "Wartortle", "Water", null),
                new Pokemon(009, "Blatoise", "Water", null),
            };

            Console.WriteLine("Digite um Id:");
            int id = int.Parse(Console.ReadLine());

            //Para chamar um atributo, você precisa fazer a seguinte estrutura:
            //nome da variável contendo o objeto.Atributo.
            //Exemplo: pokedex[i].Nome ou p1.Nome

            for (int i = 0; i < pokedex.Length; i++) {
                if (id == pokedex[i].Id) {
                    Console.WriteLine(pokedex[i]);
                    break;
                }
            }

        }

    }

}