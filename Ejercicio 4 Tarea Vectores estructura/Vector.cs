using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4_Tarea_Vectores_estructura
{
    class Vector
    {
        private int[] elemento = new int[11];
        public void ObtenerValor()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite el valor del vector");
                elemento[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Listo"); Console.ReadKey();
        }

        public void Verificar()
        {
            if (elemento[0] < elemento[1] &&
                elemento[1] < elemento[2] &&
                elemento[2] < elemento[3] &&
                elemento[3] < elemento[4] &&
                elemento[4] < elemento[5] &&
                elemento[5] < elemento[6] &&
                elemento[6] < elemento[7] &&
                elemento[7] < elemento[8] &&
                elemento[8] < elemento[9])
            {
                Console.WriteLine("Esta de menor a mayor");
                Console.WriteLine("Listo"); Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No esta de menor a mayor");
                Console.WriteLine("Listo"); Console.ReadKey();
            }


            //int proximo = elemento[0];
            //bool creciente = true;
            //bool decreciente = true;

            //for (int i = 0; i < elemento.Length; i++)
            //{
            //    if (elemento[i] < proximo) creciente = false;
            //    if (elemento[i] > proximo) decreciente = false;
            //    proximo = elemento[i]; //Asignar el proximo elemento que verificara

            //}

            //if (creciente && decreciente)
            //{
            //    Console.WriteLine("El vector tiene todos los valores repetidos");
            //}
            //else if (creciente)
            //{
            //    Console.WriteLine("El vector esta ordenado de menor a mayor");
            //}
            //else if (decreciente)
            //{
            //    Console.WriteLine("El vector esta ordenado de mayor a menor");
            //}
            //else
            //{
            //    Console.WriteLine("El vector esta desordenado");
            //}
        }
    }
}
