using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47.Pokedex2 {
    public class Pokemon {

        public Pokemon () {

        }

        public Pokemon(int id, string nome, string tipoUm, string tipoDois, int idEvolucao) {
            Id = id;
            Nome = nome;
            TipoUm = tipoUm;
            TipoDois = tipoDois;
            IdEvolucao = idEvolucao;
        }

        public int Id;
        public string Nome;
        public string TipoUm;
        public string TipoDois;
        public int IdEvolucao;
        public override string ToString() {
            return $"{Id}, {Nome}, {TipoUm}, {TipoDois}.";
        }

    }
}
