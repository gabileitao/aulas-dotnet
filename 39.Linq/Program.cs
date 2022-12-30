using System;
using System.Linq;

namespace _39.Linq {
    class Program {
        static void Main(string[] args) {
            int[] array = new[] { 4, 34, 73, 98, 100, 23, 7, 88, 999, 10, 100, 7, 88, 34, 100, 100, 33, 46, 4, 5 };

            int maior = array.Max(); //para descobrir o maior valor do array

            int menor = array.Min(); //para descobrir o menor valor do array

            int[] arrayOrdenado = array.OrderBy(i => i).ToArray(); //para ordernar do menor para o maior

            int[] arrayOrdenadoDois = array.OrderByDescending(i => i).ToArray(); //para ordenar do maior para o menor

            int[] pedacosArray = array.Skip(4).Take(5).ToArray(); // pula e pega

            int[] arrayMultiplicado = array.Select(n => n * 2).ToArray(); // modifica todos os valores do array
            bool[] arrayParOuImpar = array.Select(n => n % 2 == 0).ToArray(); // modifica todos os valores do array
            string[] arrayParOuImparTexto = array.Select(n => n % 2 == 0 ? "Par" : "Impar").ToArray(); // modifica todos os valores do array

            int[] multiplosDeQuatro = array.Where(n => n % 4 == 0).ToArray();

            Console.WriteLine($"maior: {maior} e menor: {menor}");
            Console.WriteLine(string.Join(" | ", multiplosDeQuatro));
            //Console.WriteLine(string.Join(" | ", arrayOrdenado));
            //Console.WriteLine(string.Join(" | ", arrayOrdenadoDois));
            //Console.WriteLine(string.Join(" | ", pedacosArray));

        }
    }
}
