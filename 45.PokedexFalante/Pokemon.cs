using System;
using System.Collections.Generic;
using System.Text;

namespace _45.PokedexFalante {
    public class Pokemon {

        public Pokemon(int id, string name, string typeOne, string typeTwo) {
            Id = id;
            Name = name;
            TypeOne = typeOne;
            TypeTwo = typeTwo;
        }

        public int Id;
        public string Name;
        public string TypeOne;
        public string TypeTwo;

        public override string ToString() {
            return $"{Name}, um pokemon de {TypeOne}";
        }

    }

}