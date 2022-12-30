using System;

namespace _48.Matriz {
    class Program {
        static void Main(string[] args) {
            //int[] a1 = new int[10]; //matriz (vetor = array) unidimensional

            //int[][] aa = new int[10][];
            //aa[0] = new int[10];
            //aa[0][0] = 123;

            //int[,] a2 = new int[10, 10]; //matriz bidimensional
            //a2[0, 0] = 15;


            int nLinhas = 10;
            int nColunas = 5;

            int[][] arrayDeArrays = new int[nLinhas][];

            for (int x = 0; x < nLinhas; x++) {
                int[] linha = new int[nColunas];
                for (int y = 0; y < nColunas; y++) {
                    int aaa = x + y;
                    linha[y] = aaa;
                }
                arrayDeArrays[x] = linha;
            }

            int[,] matrix = new int[nLinhas, nColunas];

            for (int x = 0; x < nLinhas; x++) {
                for (int y = 0; y < nColunas; y++) {
                    matrix[x, y] = x + y;
                }
            }

        }
    }
}
