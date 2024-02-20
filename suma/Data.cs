using System;

namespace OperacionesMatematicas
{
    public static class Data
    {
        public static int SolicitarNumero(string men)
        {
            Console.WriteLine(men);
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("pleas, Enter valid data");
            }
            return numero;
        }
    }
}
