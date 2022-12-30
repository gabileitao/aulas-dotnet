using System;

namespace _35.ValidacaoEntradaOutrosTipos {
    class Program {
        static void Main(string[] args) {

            char[] validChars = new[] { '+', '-', '*', '/' };

            //int n1 = GetInputInteger();
            float n1 = GetInputFloating();
            char op = GetInputCharacter(validChars);
            float n2 = GetInputFloating();
            //int n2 = GetInputInteger();

            switch (op) {
                case '+': Console.WriteLine(n1 + n2); break;
                case '-': Console.WriteLine(n1 - n2); break;
                case '*': Console.WriteLine(n1 * n2); break;
                case '/': Console.WriteLine(n1 / n2); break;
            }

            Console.WriteLine("Você está satisfeito com esse programa?");
            char resposta = GetInputCharacter(new[] { 'S', 'N', 's', 'n' });

            if (resposta == 's' || resposta == 'S') {
                Console.WriteLine("Muito obrigada(o).");
            } else {
                Console.WriteLine("Então vá para a puta que a(o) pariu.");
            }
        }

        static int GetInputInteger() {
            bool converteu = false;
            int numero = 0;
            while (!converteu) {
                Console.WriteLine("Digite um número: ");
                string entrada = Console.ReadLine();
                converteu = int.TryParse(entrada, out numero);
                Console.Clear();
                if (!converteu) {
                    Console.WriteLine("Entrada Inválida.");
                }
            }
            Console.Clear();
            return numero;
        }

        static float GetInputFloating() {
            bool converteu = false;
            float numero = 0;
            while (!converteu) {
                Console.WriteLine("Digite um número: ");
                string entrada = Console.ReadLine();
                converteu = float.TryParse(entrada, out numero);
                Console.Clear();
                if (!converteu) {
                    Console.WriteLine("Entrada Inválida.");
                }
            }
            Console.Clear();
            return numero;
        }

        static char GetInputCharacter(char[] caracteresAceitos) {
            bool converteu = false;
            bool contain = false; 
            char caracter = ' ';

            //enquanto o usuário não digitar um caracter válido
            //ou um que não esteja presente no array, continua rodando.
            while (!converteu || !contain) {
                Console.Write("Digite um caracter (");

                //exibe para o usuário os caracteres válidos.
                for (int i = 0; i < caracteresAceitos.Length; i++) {
                    Console.Write($" {caracteresAceitos[i]} ");
                }
                Console.WriteLine("):");
                string entrada = Console.ReadLine();
                converteu = char.TryParse(entrada, out caracter);
                Console.Clear();
                if (!converteu) {
                    Console.WriteLine("Entrada Inválida.");
                } else {

                    //verifica se o caracter que o usuário digitou está presente no array.
                    for (int i = 0; i < caracteresAceitos.Length; i++) {
                        if (caracter == caracteresAceitos[i]) {
                            contain = true;
                            break; //sai do for para não fazer perguntas desnecessárias.
                        }
                    }

                    if (!contain) {
                        Console.WriteLine("Caracter não selecionável.");
                    }
                }
            }
            Console.Clear();
            return caracter;
        }
    }
}
