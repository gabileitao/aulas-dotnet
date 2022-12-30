using System;
using System.Speech.Synthesis;


namespace _45.PokedexFalante {
    class Program {
        static void Main(string[] args) {

            Pokemon[] pokedex = new Pokemon[9];

            pokedex[0] = new Pokemon(001, "Bulbasaur", "Grass", "Poison");
            pokedex[1] = new Pokemon(002, "Ivysaur", "Grass", "Poison");
            pokedex[2] = new Pokemon(003, "Venosaur", "Grass", "Poison");
            pokedex[3] = new Pokemon(004, "Charmander", "Fire", null);
            pokedex[4] = new Pokemon(005, "Charmeleon", "Fire", null);
            pokedex[5] = new Pokemon(006, "Charizard", "Fire", "Flying");
            pokedex[6] = new Pokemon(007, "Squirtle", "Water", null);
            pokedex[7] = new Pokemon(008, "Wartortle", "Water", null);
            pokedex[8] = new Pokemon(009, "Blastoise", "Water", null);

            Console.WriteLine("Digite um Id: ");
            int id = int.Parse(Console.ReadLine());

            for (int i = 0; i < pokedex.Length; i++) {
                if (id == pokedex[i].Id) {
                    Console.WriteLine($"Este é seu Pokemon: {pokedex[i]}");
                    Falar(pokedex[i]);
                    break;
                }
            }

        }

        static void Falar(Pokemon pokemon) {

            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak(pokemon.ToString());

        }

    }
}
