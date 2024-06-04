using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Talents;

namespace New_Talents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;

        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int res = num1 + num2;
            ListaHistorico.Insert(0, "Resultado: " + res + " - data " + data);
            return res;
        }

        public int Subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            ListaHistorico.Insert(0, "Resultado: " + res + " - data " + data);
            return res;
        }

        public int Multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            ListaHistorico.Insert(0, "Resultado: " + res + " - data " + data);
            return res;
        }

        public int Dividir(int num1, int num2)
        {
            int res = num1 / num2;
            ListaHistorico.Insert(0, "Resultado: " + res + " - data " + data);
            return res;
        }

        public List<string> Historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}