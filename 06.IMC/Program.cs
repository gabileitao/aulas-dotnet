using System;
using System.Globalization;

namespace _06.IMC {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite sua altura: ");
            string alturaEntrada = Console.ReadLine();
            float altura = float.Parse(alturaEntrada, CultureInfo.InvariantCulture);

            Console.Write("Digite seu peso: ");
            string pesoEntrada = Console.ReadLine();
            float peso = float.Parse(pesoEntrada, CultureInfo.InvariantCulture);

            float imc = peso / (altura * altura);

            Console.WriteLine($"Seu IMC = {imc}");

            if (imc < 18.5) {
                Console.Write("Voce esta 'abaixo do peso'.");
            } else if (imc >= 18.5 && imc <= 24.9) {
                Console.Write("Voce esta com o 'peso normal'.");
            } else if (imc > 24.9 && imc <= 29.9) {
                Console.Write("Voce esta com 'sobrepeso'.");
            } else if (imc > 29.9 && imc <= 34.9) {
                Console.Write("Voce tem 'obesidade grau I'.");
            } else if (imc > 34.9 && imc < 40) {
                Console.Write("Voce tem 'obesidade grau II'.");
            } else {
                Console.Write("Voce tem 'obesidade morbida (grau III)'.");
            }

        }
    }
}
