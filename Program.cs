using System;

namespace DigitoVerificacionDian
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 72253222;
            int suma = 0;
            int resultado;
            string cadenaFormateada = valor.ToString("000000000000000");
            int[] serieNumerica = { 71, 67, 59, 53, 47, 43, 41, 37, 29, 23, 19, 17, 13, 7, 3 };
            for (int i = 15; i >= 1; i--)
            {
                int valorDigito = int.Parse(cadenaFormateada[i-1].ToString());
                suma += valorDigito * serieNumerica[i-1];               
            }
            int residuo = suma % 11;
            if(residuo == 0)
            {
                resultado = 0;
            }
            else if (residuo == 1)
            {
                resultado = 1;
            }
            else
            {
                resultado = 11 - residuo;
            }

            Console.WriteLine("Hello World!--" + resultado);
        }
    }
}
