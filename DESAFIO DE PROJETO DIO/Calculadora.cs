using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_DE_PROJETO_DIO
{
    public class Calculadora
    {
        private List<string> Historico {  get; set; }

        public Calculadora() 
        {
            Historico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            var result = num1 + num2;

            Historico.Insert(0, $"{num1} + {num2} = {result}");

            return result;
        }

        public int Subtrair(int num1, int num2)
        {
            var result = num1 - num2;

            Historico.Insert(0, $"{num1} - {num2} = {result}");

            return result;
        }

        public int Dividir(int num1, int num2)
        {
            if( num2 == 0)
            {
                throw new ArithmeticException("Atenção: divisão por Zero (0)");
            }

            var result = num1 / num2;

            Historico.Insert(0, $"{num1} / {num2} = {result}");

            return result;
        }

        public int Multiplicar (int num1, int num2)
        {
            var result = num1 * num2;

            Historico.Insert(0, $"{num1} * {num2} = {result}");

            return result;
        }

        public List<string> VisualizarHistorico()
        {
            return Historico.GetRange(0, Math.Min(Historico.Count, 3));
        }
    }
}
