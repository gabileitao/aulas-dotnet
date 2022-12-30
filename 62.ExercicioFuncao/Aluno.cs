using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62.MediaAlunos {
    public class Aluno {

        public Aluno(string name, float gradeOne, float gradeTwo, float gradeThree, float gradeFour) {
            Name = name;
            GradeOne = gradeOne;
            GradeTwo = gradeTwo;
            GradeThree = gradeThree;
            GradeFour = gradeFour;
        }

        public string Name;
        public float GradeOne;
        public float GradeTwo;
        public float GradeThree;
        public float GradeFour;

        public float Media () {

            return (GradeOne + GradeTwo + GradeThree + GradeFour)/4;
        }

    }
}
