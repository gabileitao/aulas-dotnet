using System;

namespace BibliotecaDeClasses {
    public static class Calculadora {

        public static string NotaToMencao(float nota) {
            if (nota < 5) {
                return "I";
            } else if (nota >= 5 && nota < 7) {
                return "R";
            } else if (nota >= 7 && nota < 9) {
                return "B";
            } else {
                return "MB";
            }
        }

    }
}
