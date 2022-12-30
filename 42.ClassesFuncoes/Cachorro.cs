using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.ClassesFuncoes {
    public class Cachorro {
        public string Cor;
        public float Peso;
        public float Altura;
        public string Raca;
        public string Nome;

        public void Latir () {
            Console.WriteLine($"{Nome} está Au, Au!");
        }

        public void MostrarInf () {
            Console.WriteLine($"{Nome} é um cachorro da raça {Raca}, que pesa {Peso} e tem {Altura.ToString("#.00")}m de altura. Suas cores são: {Cor}.");
        }
    }
}
