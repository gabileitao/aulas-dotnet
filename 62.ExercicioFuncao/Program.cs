using System;

namespace _62.MediaAlunos {
    class Program {
        static void Main(string[] args) {

            Aluno n1 = new Aluno("Pedro", 4, 7, 8, 9);
            Aluno n2 = new Aluno("Maria", 6, 8, 9, 9);
            Aluno n3 = new Aluno("Pitu", 3, 7, 2, 6);

            Aluno[] alunos = new Aluno[] { n1, n2, n3 };

            for(int i = 0; i < alunos.Length; i++) {
                float media = alunos[i].Media();
                Console.Write(alunos[i].Name + " ");
                IsAproved(media);
            }

        }

        static void IsAproved(float media) {

            if (media >= 5) {
                Console.WriteLine("Is aproved!");
            }   else {
                Console.WriteLine("Try again later!");
            }
        }
    }
}
