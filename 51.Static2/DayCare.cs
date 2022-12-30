using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51.Static2 {
    public static class DayCare {
        public static Pokemon Breed(Pokemon p1, Pokemon p2) {
            int t1 = p1.Nome.Length - 1;
            int t2 = p2.Nome.Length - 1;
            string n1 = p1.Nome.Substring(0, (int) Math.Floor(t1 / 2D));
            string n2 = p2.Nome.Substring((int)Math.Floor(t2 / 2D));
            string n3 = n1 + n2;
            Pokemon p3 = new Pokemon();
            p3.Nome = n3;
            return p3;
        }
    }
}
