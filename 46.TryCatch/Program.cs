using System;
using System.IO;

namespace _46.TryCatch {
    class Program {
        static void Main(string[] args) {
            // AULA DE COMO EVITAR ERROS/EXCEÇÕES
            //existem dois tipos de erro que podem acontecer num código:
            //1 - exceção do buildtime (tempo de compilação), na hora que está escrevendo o 
            //código, ele já aparece; Ex.: 
            //2 - exceção de runtime (tempo de execução), acontece quando o programa já está 
            //rodando [o código vai estar certo]. Ex.: loop infinito, estouro de memória, erros
            //de IO (erros de conexão, tentar ler um arquivo no PC que não existe, etc).
            //IO = input/ouput.

            string path = @"C:\Users\pedro\Desktop\oi.txt";

            //if (File.Exists(path)) {
            //    File.ReadAllText(path);
            //} else {
            //    Console.WriteLine("Arquivo não existe!");
            //}

            Console.WriteLine("Iniciando programa!");

            try {
                Console.WriteLine($"Tentando ler o arquivo {path}.");
                File.ReadAllText(path);
                Console.WriteLine("Leitura executada com sucesso!");
            } catch (Exception e) {
                Console.WriteLine("Falha ao ler o arquivo.");
                Console.WriteLine(e);
            }

        }
    }
}
