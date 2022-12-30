using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74.ValidadeDeEstoque {
    public class Estoque {

        public string CodigoDeBarra;
        public DateTime Vencimento;

        public Estoque(string codigoDeBarra, DateTime vencimento) {
            CodigoDeBarra = codigoDeBarra;
            Vencimento = vencimento;
        }

    }
}
