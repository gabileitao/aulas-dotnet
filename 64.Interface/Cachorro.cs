using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64.Interface {
    public class Cachorro : Animal {
        public string EmitirSom() {
            return "Cachorro faz au au.";
        }

        public string MarcarTerritorio() {
            return "Cachorro faz xixi.";
        }
    }
}
