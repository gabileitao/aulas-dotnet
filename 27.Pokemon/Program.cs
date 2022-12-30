using System;
using System.Threading;

namespace _27.Pokemon {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Ganhe do Muk: Pikachu x Muk");
            int pikachu = 100;
            int muk = 100;

            while (pikachu > 0 && muk > 0) {
                Console.WriteLine($"Pikachu: {pikachu} de vida e Muk: {muk} de vida.");

                Console.WriteLine("1. ThunderBolt (90)");
                Console.WriteLine("2. Iron Tail (80)");
                Console.WriteLine("3. Thundershock (40)");
                Console.WriteLine("4. Tackle (20)");

                Console.Write("Escolha um ataque para Pikachu: ");
                int ataquePik = int.Parse(Console.ReadLine());

                switch (ataquePik) {
                    case 1: { 
                        muk -= 90;
                        Console.WriteLine("Pikachu usou Thunderbolt e muk sofreu 90 de dano.");
                        break;
                    }
                    case 2: { 
                        muk -= 80;
                        Console.WriteLine("Pikachu usou Iron Tail e muk sofreu 80 de dano.");
                        break; 
                    }
                    case 3: { 
                        muk -= 40;
                        Console.WriteLine("Pikachu usou Thundershock e muk sofreu 40 de dano.");
                        break; 
                    }
                    case 4: { 
                        muk -= 20;
                        Console.WriteLine("Pikachu usou Tackle e muk sofreu 20 de dano.");
                        break; 
                    }
                    default: {
                        Console.WriteLine("Opção inválida.");
                        continue;
                    }
                }

                Thread.Sleep(2000);

                if (muk > 0) {
                    //Poison Jab (70)
                    //Sludge (40)
                    //Acid (40)
                    //Toxic (120)

                    int ataqueMuk = new Random().Next(1, 5);

                    switch (ataquePik) {
                        case 1: {
                            pikachu -= 70;
                            Console.WriteLine("Muk usou Poison Jab e Pikachu sofreu 70 de dano.");
                            break;
                        }
                        case 2: {
                            pikachu -= 40;
                            Console.WriteLine("Muk usou Sludge e Pikachu sofreu 40 de dano.");
                            break;
                        }
                        case 3: {
                            pikachu -= 40;
                            Console.WriteLine("Muk usou Acid e Pikachu sofreu 40 de dano.");
                            break;
                        }
                        case 4: {
                            pikachu -= 120;
                            Console.WriteLine("Muk usou Toxic e Pikachu sofreu 120 de dano.");
                            break;
                        }
                    }
                }
                Thread.Sleep(3000);

                Console.Clear();
            }

            if (pikachu <= 0) {
                Console.WriteLine("Pikachu desmaiou, Muk venceu.");
            } else {
                Console.WriteLine("Muk desmaiou, Pikachu venceu.");
            }
        }
    }
}
