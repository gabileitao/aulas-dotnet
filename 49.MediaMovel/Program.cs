using System;
using System.Linq;

namespace _49.MediaMovel {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Escreva os valores dos casos dos últimos 7 dias com um espaço entre eles: ");
            string entrada = Console.ReadLine();

            string[] entradinhas = entrada.Split(' ');

            //int[] mortes = new int[entradinhas.Length];

            int soma = 0;

            for (int i = 0; i < entradinhas.Length; i++) {
                //mortes[i] = int.Parse(entradinhas[i]);
                soma += int.Parse(entradinhas[i]);
            }

            //    0      1        2
            // ["cu", "pinto", "anus"]

            foreach (string entradinha in entradinhas) {
                soma += int.Parse(entradinha);
            }

            

            //int somaPedro = entrada.Split(' ').Sum(e => int.Parse(e)) / 7;

            double MM = soma / entradinhas.Length;

            double mmArredondada = Math.Round(MM);

            Console.WriteLine($"A média móvel dos último {entradinhas.Length} dias foi {mmArredondada:0}.");



        }
    }
}
