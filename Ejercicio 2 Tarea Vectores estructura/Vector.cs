using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2_Tarea_Vectores_estructura
{
    class Vector
    {
        private int[] vector1 = new int[4];
        private int[] vector2 = new int[4];
        private int[] vector3 = new int[4];

        public void ObtenerValor()
        {
            Console.WriteLine("Valores del vector #1");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Vector #1 - Digite el valor posicion #: " + i);
                vector1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Listo"); Console.ReadKey();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Valores del vector #2");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Vector #2 - Digite el valor posicion #: " + i);
                vector2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Listo"); Console.ReadKey();
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < 4; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
        }

        public void MostraValor()
        {
            int x = 0;
            foreach (var item in vector3)
            {
                x = x + 1;
                Console.WriteLine("El valor sumado de la misma posicion #" +x +" de los vectores 1 y 2 es: " + item);
            }
            Console.WriteLine("Listo"); Console.ReadKey();
        }
    }
}
