using System;

namespace Experiencia {

    class Program {

        static void Main(string[] args) {

            int[] thresholds = GetThresholds(100);

            bool exp = false;
            int experiencia = 0;

            while (!exp) {

                int level = GetLevel(experiencia, thresholds);
                Console.WriteLine($"Seu Pokemon está no nível {level} e com {experiencia}.");

                Console.WriteLine("Digite uma quantidade de experiência: ");
                int entrada = int.Parse(Console.ReadLine());

                Console.Clear();

                experiencia += entrada;

                if (entrada == 0) {
                    exp = true;
                }

            }
        }

        static int GetLevel(int total, int[] thresholds) {
            for (int i = 0; i < thresholds.Length; i++) {
                if (total <= thresholds[i] && total < thresholds[i + 1]) {
                    return i + 1;
                }
            }
            return 0;
        }

        static int[] GetThresholds(int numberOfLevels) {
            int[] thresholds = new int[numberOfLevels];
            for (int i = 0; i < thresholds.Length; i++) {
                thresholds[i] = Fast(i + 1);
                //thresholds[i] = MediumSlow(i+1);
            }
            return thresholds;
        }

        static int Fast(int n) {
            return (int)(4 * Math.Pow(n, 3)) / 5;
        }

        static double MediumFast(int n) {
            return Math.Pow(n, 3);
        }

        static double MediumSlow(int n) {
            return ((6 / 5) * Math.Pow(n, 3)) - (15 * Math.Pow(n, 2)) + (100 * n) - 140;
        }

    }

}