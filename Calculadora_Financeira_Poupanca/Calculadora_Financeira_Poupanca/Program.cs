using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Financeira_Poupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis para a aplicação.
            double valorInvestido = 0;
            int mesesPeriodo = 0;
            double resultado = 0;
            string mesPlural = string.Empty;

            //Usuário informa o valor a ser aplicado.
            Console.Write("Quanto deseja investir por Mês: ");
            valorInvestido = double.Parse(Console.ReadLine());

            //Usuário informa a quantidade de meses que vai aplicar.
            Console.Write("Quantos meses pretende investir na Poupança: ");
            mesesPeriodo = int.Parse(Console.ReadLine());

            //Resultado já dando o valor total do que investil e do que será investido
            resultado = (valorInvestido * mesesPeriodo) * 0.04;

            if (mesesPeriodo == 1)
            {
                mesPlural = "mês";
            }

            else
            {
                mesPlural = "meses";
            }

            //Usuário receber a mensagem com o valor total do rendimento no final do período desejado.
            Console.WriteLine("O Valor total do redimento da Poupança será de: {0} no período de: {1} {2}", resultado, mesesPeriodo, mesPlural);
            Console.ReadKey();
        }
    }
}
