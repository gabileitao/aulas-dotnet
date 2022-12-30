using System;

namespace _25.Livraria {
    class Program {
        static void Main(string[] args) {
            int numero = 1;
            int total = 0;

            while (numero != 0) {
                Console.WriteLine("Olá, bem-vindo a livraria Babel!");
                Console.WriteLine($"Total de sua compra é {total}.");
                Console.WriteLine("Escolha um livro:");
                Console.WriteLine(@"1 - Harry Potter: R$40,00; 
2 - Percy Jackson: R$35,00; 
3 - Rangers - Ordem dos Arqueiros: R$50,00;
4 - O Gato Negro: R$5,00;
5 - A Rebelde do Deserto: R$27,00;
6 - Magisterium: R$24,00;
7 - Educating Caroline: R$43,00;
8 - Ranma 1/2: R$14,00;
9 - Ataque dos Titãs: R$25,00;
0 - Total."
                        );
                Console.Write("Escreva o número: ");
                string entrada = Console.ReadLine();
                numero = int.Parse(entrada);
                Console.Clear();

                switch (numero) {
                    case 1: total += 40; break;
                    case 2: total += 35; break;
                    case 3: total += 50; break;
                    case 4: total += 5; break;
                    case 5: total += 27; break;
                    case 6: total += 24; break;
                    case 7: total += 43; break;
                    case 8: total += 14; break;
                    case 9: total += 25; break;
                }
            }

            Console.Write($"O total da sua compra é {total}.");
        }
    }
}
