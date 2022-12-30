using System;

namespace _67.GetLengthMatrix {
    class Program {
        static void Main(string[] args) {

            int[,] n = new int[3, 4];

            int nLinhas = n.GetLength(0);
            int nColunas = n.GetLength(1);

            for(int x = 0; x < nLinhas; x++) {
                for (int y = 0; y < nColunas; y++) {
                    Console.Write(" ");
                    Console.Write(n[x,y]);
                }
                Console.WriteLine();
            }

        }
    }
}
