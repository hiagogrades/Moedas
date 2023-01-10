using System;
using System.Globalization;

namespace FormatandoMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m;

            Console.WriteLine(valor);

            //Creando uma especificação de cultura
            Console.WriteLine(valor.ToString(
                "C", //Formato de Curence (moeda), converte para moeda real, colocando o $
                CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine(valor.ToString(
                "C", //Formato de Curence (moeda), converte para moeda dolar, colocando o $
                CultureInfo.CreateSpecificCulture("es-US")));
        }
    }
}
