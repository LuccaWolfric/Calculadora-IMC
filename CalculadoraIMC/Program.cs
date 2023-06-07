using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("Bem Vindo a Calculadora de Indice de Massa Corporal - IMC");

            Console.Write("Primeiro digite seu peso atual: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("\nAgora digite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

            string classificacao = "";

            if (IMC < 18.5)
            {
                classificacao = "BAIXO PESO";
            }
            else if (IMC > 18.6 && IMC < 24.9)
            {
                classificacao = "PESO IDEAL";
            }
            else if (IMC > 25 && IMC < 29.9)
            {
                classificacao = "SOBREPESO";
            }
            else if (IMC > 30 && IMC <34.9)
            {
                classificacao = "OBESIDADE GRAU I";
            }
            else if (IMC > 35 && IMC < 39.9)
            {
                classificacao = "OBESIDADE GRAU II";
            }
            else if (IMC > 40)
            {
                classificacao = "OBESIDADE GRAU III";
            }

            double truncateIMC = Math.Truncate(IMC * 100) / 100;

            Console.Write("Seu IMC é " + truncateIMC + "kg/m² --> ");
            Console.WriteLine("classificado como " + classificacao);
            Console.ReadKey();
        }
    }
}
