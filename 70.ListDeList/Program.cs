using System;
using System.Collections.Generic;

namespace _70.ListDeList {
    class Program {
        static void Main(string[] args) {

            Random random = new Random();

            List<List<int>> lista = new List<List<int>>();

            //lista não tem tamanho físico, então é necessário setar um.
            int icount = 10;

            for (int x = 0; x < icount; x++) {
                //criando as listas nas posições específicas.
                lista.Add(new List<int>());

                //as listas internas também não terão tamanho específico, é preciso escolher um
                //para que a contagem seja feita - função do random.Next() aqui.
                int jcount = random.Next(5, 15);
                for (int y = 0; y < jcount; y++) {
                    lista[x].Add(random.Next(10, 20));
                }
            }

            //este pedaço do código faz:
            //O primeiro for irá percorrer a lista exterior, passando por cada lista interna.
            //Ao entrar na primeira posição da lista exterior, o segundo for percorrerá a 
            //lista daquela posição até o fim, mostrando os números adicionados a ela lado
            //a lado. Quando chega ao fim, sai desse segundo for, pula uma linha e volta ao
            //primeiro, para contar até o final.

            for (int i = 0; i < lista.Count; i++) {
                for (int j = 0; j < lista[i].Count; j++) {
                    Console.Write($"{lista[i][j]}, ");
                }
                Console.WriteLine();
            }

        }
    }
}
