using System;

namespace _26.Petshop {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olá, bem-vindo à petshop Guassu!");

            Console.Write("Agora, me diga quantos cachorros você tem: ");
            string entrada = Console.ReadLine();
            int quantidade = int.Parse(entrada);

            int total = 0;

            for (int i = 1; i <= quantidade; i++) {
                Console.Write($"Me fala o peso do cachorro {i}:");
                string entradaUm = Console.ReadLine();
                int peso = int.Parse(entradaUm);

                if (peso <= 15) {
                    Console.WriteLine($" Para dar banho neste bebê, cobro: 10 reais.");
                    total += 10;
                } else if (peso <= 25) {
                    Console.WriteLine($" Para dar banho nele, cobro: 20 reais.");
                    total += 20;
                } else {
                    Console.WriteLine($" Para dar banho neste bebezão, cobro: 30 reais.");
                    total += 30;
                }
            }

            Console.WriteLine($"O valor para dar banho nos seus dogs é {total}.");
        }
    }
}
