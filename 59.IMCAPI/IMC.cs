using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _59.IMCAPI {
    public class IMC {

        public float Weight;
        public float Height;

        public string VerifyIMC() {
            float imc = Weight / (Height * Height);

            return $"Seu IMC = {imc}";

            if (imc < 18.5) {
                return "Voce esta 'abaixo do peso'.";
            } else if (imc >= 18.5 && imc <= 24.9) {
                return "Voce esta com o 'peso normal'.";
            } else if (imc > 24.9 && imc <= 29.9) {
                return "Voce esta com 'sobrepeso'.";
            } else if (imc > 29.9 && imc <= 34.9) {
                return "Voce tem 'obesidade grau I'.";
            } else if (imc > 34.9 && imc < 40) {
                return "Voce tem 'obesidade grau II'.";
            } else {
                return "Voce tem 'obesidade morbida (grau III)'.";
            }
        }

    }
}