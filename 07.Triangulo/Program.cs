using System;

namespace _07.Triangulo {
    class Program {
        static void Main(string[] args) {
            Console.Write("Insira o lado 'a' do triângulo: ");
            string ladoAEntrada = Console.ReadLine();
            float ladoA = float.Parse(ladoAEntrada);

            Console.Write("Insira o lado 'b' do triângulo: ");
            string ladoBEntrada = Console.ReadLine();
            float ladoB = float.Parse(ladoBEntrada);

            Console.Write("Insira o lado 'c' do triângulo: ");
            string ladoCEntrada = Console.ReadLine();
            float ladoC = float.Parse(ladoCEntrada);

            bool ladoAValido = Math.Abs(ladoB - ladoC) < ladoA && ladoA < ladoB + ladoC;
            bool ladoBValido = Math.Abs(ladoA - ladoC) < ladoB && ladoB < ladoA + ladoC;
            bool ladoCValido = Math.Abs(ladoA - ladoB) < ladoC && ladoC < ladoA + ladoB;

            if (ladoAValido && ladoBValido && ladoCValido) {
                if ((ladoA == ladoB && ladoA != ladoC) || (ladoA == ladoC && ladoA != ladoB) || (ladoB == ladoC && ladoB != ladoA)) {
                    Console.WriteLine("Voce tem um triangulo isosceles.");
                } else if (ladoA == ladoB && ladoB == ladoC) {
                    Console.WriteLine("Voce tem um triangulo equilatero.");
                } else if (ladoA != ladoB && ladoB != ladoC) {
                    Console.WriteLine("Voce tem um triangulo escaleno.");
                }
            } else {
                Console.WriteLine("Isto nao e um triangulo.");
            }
        }
    }
}
