using System;

namespace _47.Pokedex2 {
    class Program {
        static void Main(string[] args) {
            Pokemon[] pokedex = new Pokemon[] {
                new Pokemon(001, "Bulbasaur", "Grass", null, 002),
                new Pokemon(002, "Ivysaur", "Grass", null, 003),
                new Pokemon(003, "Venusaur", "Grass", "Poison", 000),
                new Pokemon(004, "Charmander", "Fire", null, 005),
                new Pokemon(005, "Charmeleon", "Fire", null, 006),
                new Pokemon(006, "Charizard", "Fire", "Flying", 000),
                new Pokemon(007, "Squirtle", "Water", null, 008),
                new Pokemon(008, "Wartortle", "Water", null, 009),
                new Pokemon(009, "Blatoise", "Water", null, 000),
            };

            Console.WriteLine("Digite um Id:");
            int id = int.Parse(Console.ReadLine());

            Pokemon found = FindPokemon(id, pokedex);

            Console.WriteLine(found);

            if (found.IdEvolucao != 0) {
                Pokemon evolucaoUm = FindPokemon(found.IdEvolucao, pokedex); ;
                Console.WriteLine(evolucaoUm);
                if (evolucaoUm.IdEvolucao != 0) {
                    Pokemon evolucaoDois = FindPokemon(evolucaoUm.IdEvolucao, pokedex);
                    Console.WriteLine(evolucaoDois);
                } else {
                    Console.WriteLine("Seu Pokémon não tem mais evoluções.");
                }
            } else {
                Console.WriteLine("Seu Pokémon não tem evoluções");
            }
        }

        static Pokemon FindPokemon(int id, Pokemon[] pokemons) {
            for (int i = 0; i < pokemons.Length; i++) {
                if (id == pokemons[i].Id) {
                    return pokemons[i];
                }
            }
            return null;
        }

    }
}
