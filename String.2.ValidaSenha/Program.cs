using System;
using String.Utils;

namespace String._2.ValidaSenha {
    class Program {
        static void Main(string[] args) {
            //string senhaFraca = "Abc123";
            //bool validaSenha = StringUtils.VerificaSenha(senhaFraca);
            //Console.WriteLine(validaSenha ? "Tá boa" : "Tá ruim");

            string senhaForte = "Viagem3!";
            Console.WriteLine(ValidaSenha(senhaForte));

        }

        public static string ValidaSenha(string senha) {
            bool validaSenha = StringUtils.VerificaSenha(senha);
            if (validaSenha) {
                return "Senha dentro dos padrões";
            } else {
                return "Senha fora dos padrões.";
            }
        }
    }
}
