using System;
using System.Linq;

namespace Seleccion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string numbers = "5,57,8,9,14,55,62,4,1,3,0,25,48,96,33,24,56,45,89,87,97";
            int[] vector = numbers.Split(',').Select(x => Convert.ToInt32(x)).ToArray();
            Console.WriteLine();
            Console.WriteLine("Vector ordenado:");
            Console.WriteLine(string.Join(",", Ordenar(vector)));
            Console.WriteLine();
            Console.WriteLine("Presiona una tecla para salir.");
            Console.ReadKey();
        }

        private static int[] Ordenar(int[] vector)
        {
            int menor, posicion, auxiliar;

            for (int i = 0; i < vector.Length - 1; i++)
            {
                menor = vector[i];
                posicion = i;

                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[j] < menor)
                    {
                        menor = vector[j];
                        posicion = j;
                    }
                }

                if (posicion != i)
                {
                    auxiliar = vector[i];
                    vector[i] = vector[posicion];
                    vector[posicion] = auxiliar;
                }
            }

            return vector;
        }
    }
}
