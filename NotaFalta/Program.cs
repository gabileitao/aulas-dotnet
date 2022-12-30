using System;

namespace NotaFalta {
    class Program {
        static void Main(string[] args) {
            //E1P que o usuário digita a média do aluno,
            //quantidade total de aulas e quantidade de faltas.
            //Então, deverá mostrar se o aluno está aprovado.
            //Requisitos para aprovação: 75% de presença e 6 média.

            int media = GetIntNumber("Digite a média: ");
            int quantidadeAulasBim = GetIntNumber("Digite a quantidade de aulas do Bimestre: ");
            int quantidadeFaltas = GetIntNumber("Digite a quantidade de faltas do aluno: ");

            int presenca = 100 - ((quantidadeFaltas * 100) / quantidadeAulasBim);

            //double p = (quantidadeAulasBim - quantidadeFaltas) / quantidadeAulasBim;

            if (presenca >= 75 && media >= 6) {
                Console.WriteLine("Aprovado.");
            } else {
                Console.WriteLine("Reprovado.")
            }

        }

        static int GetIntNumber(string msg) {
            bool number = false;
            int valor = 0;

            while (!number) {
                Console.WriteLine(msg);
                string entrada = Console.ReadLine();
                number = int.TryParse(entrada, out valor);

                if (!number) {
                    Console.WriteLine("Entrada inválida, digite um número!");
                }
            }

            return valor;
        }

    }
}
