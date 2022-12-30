using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71.Generics {
    public class Caixa<T> {

        //public int coisa;

        //public Caixa(int coisa) {
        //    //this é um ponteiro para o próprio objeto, mais comum para Java.
        //    this.coisa = coisa;
        //} 

        public T Coisa;

        public Caixa (T coisa) {
            Coisa = coisa;
        }

    }
}
