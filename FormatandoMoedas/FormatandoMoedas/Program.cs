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

            Console.WriteLine("Formatação de moedas:");
            //Creando uma especificação de cultura
            Console.WriteLine(valor.ToString(
                "C", //Formato de Curence (moeda), converte para moeda real, colocando o $
                CultureInfo.CreateSpecificCulture("pt-BR")));

            Console.WriteLine(valor.ToString(
                "C", //Formato de Curence (moeda), converte para moeda dolar, colocando o $
                CultureInfo.CreateSpecificCulture("es-US")));


            Console.WriteLine("Métodos para arredondamento de valor:");
            
            //Faz o arredondamento do valor
            Console.WriteLine("Round = " + Math.Round(valor));

            //Ceiling => Teto, telhado
            //Faz o arredondamento sempre para "cima"
            Console.WriteLine("Ceiling = " + Math.Ceiling(valor));

            //Floor => chão
            //Sempre arredonda para baixo
            Console.WriteLine("Floor = " + Math.Floor(valor));

        }
    }
}
