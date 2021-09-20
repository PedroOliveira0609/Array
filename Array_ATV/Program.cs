using System;

namespace ArrayATV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros;
            numeros = new string [10];
            numeros[0] = "1";
            numeros[1] = "2";
            numeros[2] = "3";
            numeros[3] = "4";
            numeros[4] = "5";
            numeros[5] = "6";
            numeros[6] = "7";
            numeros[7] = "8";
            numeros[8] = "9";
            numeros[9] = "10";

            for (int i = 0; i < numeros.Length ; i++)
            {
                Console.WriteLine($" Os números são : {numeros[i]}");
            }
        }
    }
}