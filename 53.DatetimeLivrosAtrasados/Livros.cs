using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.DatetimeLivrosAtrasados {
    class Livro {

        public Livro(string titulo, DateTime dataAluguel) {
            Titulo = titulo;
            DataAluguel = dataAluguel;
        }

        public string Titulo;
        public DateTime DataAluguel;
    }
}
