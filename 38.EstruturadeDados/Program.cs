using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace _38.EstruturadeDados {
    class Program {
        static void Main(string[] args) {
            //ARRAY - tamanho fixo
            int[] array = new int[10];
            array[3] = 123;
            array[9] = 456;
            int nUm = array[4];
            int tamanhoArray = array.Length;

            //LIST - tamanho dinâmico
            List<int> lista = new List<int>();
            lista.Add(123);
            lista.Add(456);
            int nDois = lista[2];
            int tamanhoDaLista = lista.Count;
            lista.Remove(6); // vai remover o valor 6 (foda-se a posição)
            lista.RemoveAt(6); // vai remover o valor na posição 6

            //STACK - tamanho dinânico (first in last out: filo)
            Stack<int> pilha = new Stack<int>();
            pilha.Push(123);
            pilha.Push(456);
            int valorUm = pilha.Pop(); //retorna 456

            //QUEU - tamanho dinânico (first in first out: fifo)
            Queue<int> fila = new Queue<int>();
            fila.Enqueue(123);
            fila.Enqueue(456);
            int valorFila = fila.Dequeue(); //retorna 123

        }
    }
}
