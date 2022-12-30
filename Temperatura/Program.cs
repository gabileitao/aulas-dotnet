using System;

namespace Temperatura {
    class Program {
        static void Main(string[] args) {

            float celsius = GetIntNumber("Digite a temperatura em graus celsius: ");

            double fahrenheit = ToFahrenheit(celsius);

            double kelvin = ToKelvin(celsius);

            Console.WriteLine($"Sua tempera em {celsius} ficaria {fahrenheit}°F e {kelvin}°K.");

        }

        static float ToFahrenheit(float temperatura) {
            float fahrenheit = ((temperatura * 9) / 5) + 32;
            return fahrenheit;
        }

        static double ToKelvin (float temperatura) {
            double kelvin = temperatura + 273.15;
            return kelvin;
        }

        static float GetIntNumber(string msg) {
            bool number = false;
            float valor = 0;

            while (!number) {
                Console.WriteLine(msg);
                string entrada = Console.ReadLine();
                number = float.TryParse(entrada, out valor);

                if (!number) {
                    Console.WriteLine("Entrada inválida, digite um número!");
                }
            }

            return valor;
        }
    }
}
