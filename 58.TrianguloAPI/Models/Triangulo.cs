using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _58.TrianguloAPI.Models {
    public class Triangulo {

        public float ladoA;
        public float ladoB;
        public float ladoC;

        public string GetTriangleType() {
            bool ladoAValido = Math.Abs(ladoB - ladoC) < ladoA && ladoA < ladoB + ladoC;
            bool ladoBValido = Math.Abs(ladoA - ladoC) < ladoB && ladoB < ladoA + ladoC;
            bool ladoCValido = Math.Abs(ladoA - ladoB) < ladoC && ladoC < ladoA + ladoB;

            if (ladoAValido && ladoBValido && ladoCValido) {
                if ((ladoA == ladoB && ladoA != ladoC) || (ladoA == ladoC && ladoA != ladoB) || (ladoB == ladoC && ladoB != ladoA)) {
                    return "Voce tem um triangulo isosceles.";
                } else if (ladoA == ladoB && ladoB == ladoC) {
                    return "Voce tem um triangulo equilatero.";
                } else if (ladoA != ladoB && ladoB != ladoC) {
                    return "Voce tem um triangulo escaleno.";
                }
                return "Isto nao e um triangulo.";
            } else {
                return "Isto nao e um triangulo.";
            }
        }

    }
}