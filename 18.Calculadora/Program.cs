using System;

namespace _18.Calculadora {
    class Program {
        static float getInput(string msg) {
            bool deubom = false;
            float numero = 0;
            while (deubom == false) {
                Console.Write(msg);
                string entrada = Console.ReadLine();
                deubom = float.TryParse(entrada, out numero);
                if (!deubom) {
                    Console.WriteLine("Entrada inválida.");
                }
            }
            return numero;
        }

        static char getInputOp(string msg) {
            bool deubom = false;
            char operacao = default(char);
            while (deubom == false) {
                Console.Write(msg);
                string entrada = Console.ReadLine();
                deubom = char.TryParse(entrada, out operacao);
                if (!deubom) {
                    Console.WriteLine("Entrada inválida.");
                } else {
                    if (operacao != '-' && operacao != '+' && operacao != '*' && operacao != '/' && operacao != '%' && operacao != '^') {
                        Console.WriteLine("Operação inválida.");
                        deubom = false;
                    }
                }
            }
            return operacao;
        }

        static void Main(string[] args) {

            float numero1 = getInput("Digite um número: ");
            float numero2 = getInput("Digite outro número: ");
            float operacao = getInputOp("Digite uma operação: ");

            switch (operacao) {
                case '+': Console.WriteLine($"Seu resultado é: {numero1 + numero2}"); break;
                case '-': Console.WriteLine($"Seu resultado é: {numero1 - numero2}"); break;
                case '*': Console.WriteLine($"Seu resultado é: {numero1 * numero2}"); break;
                case '/': Console.WriteLine($"Seu resultado é: {numero1 / numero2}"); break;
                case '%': Console.WriteLine($"Seu resultado é: {numero1 % numero2}"); break;
                case '^': Console.WriteLine($"Seu resultado é: {Math.Pow(numero1, numero2)}"); break;
            }

        }
    }
}
