using System;

namespace _50.DateTimeAula {
    class Program {
        static void Main(string[] args) {
            DateTime data = new DateTime();
            Console.WriteLine(data);

            //para modificar o formato da data:
            //data2.ToString("yyyy-MM-dd HH:mm:ss.fff")

            DateTime data2 = DateTime.Now;
            Console.WriteLine(data2);

            Console.WriteLine(data2.AddDays(2));
            //para somar X dias na data escolhida

            Console.WriteLine(data2.DayOfWeek);
            //retorna o dia da semana de 0 a 6

            DateTime dataInicio = new DateTime(2022, 06, 25, 20, 50, 12);

            DateTime dataFim = new DateTime(2022, 12, 31, 02, 13, 40);

            TimeSpan intervalo = dataFim - dataInicio;
            Console.WriteLine(intervalo.TotalDays);
            Console.WriteLine(intervalo.TotalSeconds);
            //.TotalDays, .TotalSeconds e afins retornam double ou long.

            Console.WriteLine(intervalo);

            string dataEmString = "2000-02-05";
            DateTime dataParse = DateTime.Parse(dataEmString);
            Console.WriteLine(dataParse);

        }
    }
}
