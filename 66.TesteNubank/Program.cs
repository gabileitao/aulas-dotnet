using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Usuario {

    public Usuario() {
        Nome = "";
        Saldo = 0;
    }

    public string Nome;
    public int Saldo;

}

class Result {

    /*
     * Complete the 'smallestNegativeBalance' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts 2D_STRING_ARRAY debts as parameter.
     */

    public static List<Usuario> Usuarios;

    public static List<string> smallestNegativeBalance(List<List<string>> debts) {

        Usuarios = new List<Usuario>();

        for (int i = 0; i < debts.Count(); i++) {
            string devedor = debts[i][0];
            string credor = debts[i][1];
            int valor = int.Parse(debts[i][2]);
            FindAndSetSaldo(devedor, -valor);
            FindAndSetSaldo(credor, +valor);
        }

        List<Usuario> negativos = new List<Usuario>();

        // filtrar apenas os negativos
        for (int i = 0; i < Usuarios.Count(); i++) {
            if (Usuarios[i].Saldo < 0) {
                negativos.Add(Usuarios[i]);
            }
        }

        if (negativos.Count() == 0) {
            List<string> r = new List<string>();
            r.Add("Nobody has a negative balance");
            return r;
        }

        // descobrir o menor saldo (dos devedores)
        // ou seja, quem está devendo mais
        int menor = 0;
        for (int i = 0; i < Usuarios.Count(); i++) {
            if (Usuarios[i].Saldo < menor) {
                menor = Usuarios[i].Saldo;
            }
        }

        // descobrir os nomes de quem está devendo menos
        // pode ser que tenha mais de um com a mesma "menor divida"
        List<string> menoresDevedores = new List<string>();
        for (int i = 0; i < Usuarios.Count(); i++) {
            if (Usuarios[i].Saldo == menor) {
                menoresDevedores.Add(Usuarios[i].Nome);
            }
        }

        return menoresDevedores.OrderBy(s => s).ToList();

    }

    public static void FindAndSetSaldo(string nome, int valor) {

        // verifica se ele está na lista
        bool estaNaLista = false;
        for (int i = 0; i < Usuarios.Count; i++) {
            if (Usuarios[i].Nome == nome) {
                estaNaLista = true;
                break;
            }
        }

        // cria usuario na lista caso não exista
        if (!estaNaLista) {
            Usuario u = new Usuario();
            u.Nome = nome;
            u.Saldo = 0;
            Usuarios.Add(u);
        }

        // procura na lista e altera o saldo
        for (int i = 0; i < Usuarios.Count; i++) {
            if (Usuarios[i].Nome == nome) {
                Usuarios[i].Saldo += valor;
            }
        }

    }

}
class Solution {
    public static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int debtsRows = Convert.ToInt32(Console.ReadLine().Trim());
        int debtsColumns = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> debts = new List<List<string>>();

        for (int i = 0; i < debtsRows; i++) {
            debts.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        List<string> result = Result.smallestNegativeBalance(debts);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
