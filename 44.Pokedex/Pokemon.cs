using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Pokedex {
    public class Pokemon {

        public Pokemon () {

        }

        public Pokemon(int id, string nome, string tipoUm, string tipoDois) {
            Id = id;
            Nome = nome;
            TipoUm = tipoUm;
            TipoDois = tipoDois;
        }

        public int Id;
        public string Nome;
        public string TipoUm;
        public string TipoDois;
        public override string ToString() {
            return $"{Id}, {Nome}, {TipoUm}, {TipoDois}.";
        }

    }
}
