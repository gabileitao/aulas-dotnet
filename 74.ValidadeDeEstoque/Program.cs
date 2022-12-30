using System;

namespace _74.ValidadeDeEstoque {
    class Program {
        static void Main(string[] args) {

            Estoque[] estoque = new Estoque[]{
                new Estoque("000-1",new DateTime(2023, 5, 09)),
                new Estoque("000-2",new DateTime(2023, 4, 05)),
                new Estoque("000-3",new DateTime(2023, 3, 10)),
                new Estoque("000-4",new DateTime(2023, 7, 09)),
                new Estoque("000-5",new DateTime(2023, 5, 15)),
                new Estoque("000-6",new DateTime(2023, 4, 30)),
                new Estoque("000-7",new DateTime(2023, 5, 07)),
                new Estoque("000-8",new DateTime(2023, 7, 09)),
                new Estoque("000-9",new DateTime(2023, 3, 21)),
                new Estoque("000-10",new DateTime(2023, 5, 18)),
            };

            DateTime dataAtual = new DateTime(2023, 5, 10);
            int alertaVencendo = 7;

            //for (int i = 0; i < estoque.Length; i++) {
            //    Estoque u = estoque[i];
            //}

            foreach (Estoque unidade in estoque) {
                TimeSpan diferenca = unidade.Vencimento - dataAtual;
                int diferencaEmDias = (int)diferenca.TotalDays;

                if(diferencaEmDias < 0) {
                    Console.WriteLine($"{unidade.CodigoDeBarra} vencido. Venceu há {Math.Abs(diferencaEmDias)} dias.");
                } else if (diferencaEmDias <= alertaVencendo) {
                    Console.WriteLine($"{unidade.CodigoDeBarra} está próximo de vencer. Vencerá em {diferencaEmDias} dias.");
                }
            }
        }
    }
}
