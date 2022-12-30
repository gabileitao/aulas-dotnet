using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.ClassesConstrutores {
    public class Cachorro {

        public Cachorro(string nome, float peso, float altura, string raca, string cor) {
            Nome = nome;
            Cor = cor;
            Peso = peso;
            Altura = altura;
            this.Raca = raca;
        }

        public string Cor;
        public float Peso;
        public float Altura;
        public string Raca;
        private string Nome;

        public void Latir () {
            Console.WriteLine($"{Nome} está Au, Au!");
        }

        public void MostrarInf () {
            Console.WriteLine($"{Nome} é um cachorro da raça {Raca}, que pesa {Peso} e tem {Altura.ToString("#.00")}m de altura. Suas cores são: {Cor}.");
        }



    }
}
