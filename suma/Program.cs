using OperacionesMatematicas;
using System;

namespace AppPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = Data.SolicitarNumero("Enter the first number:");
            int numero2 = Data.SolicitarNumero("Enter the second number:");

            int resultado = Sumadora.Sumar(numero1, numero2);
            Console.WriteLine($"result: {resultado}");
        }
    }
}
