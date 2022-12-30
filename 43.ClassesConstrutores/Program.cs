using System;

namespace _43.ClassesConstrutores {
    class Program {
        static void Main(string[] args) {

            Cachorro c1 = new Cachorro("Shade", 30, 1.61f, "Pastor alemão", "preto e marrom");

            c1.Latir();
            c1.MostrarInf();

        }
    }
}
