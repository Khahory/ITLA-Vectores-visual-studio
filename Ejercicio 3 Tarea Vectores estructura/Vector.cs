using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3_Tarea_Vectores_estructura
{
    class Vector
    {
        private int[] cursoA = new int[5];
        private int[] cursoB = new int[5];

        public void EnviarNotas()
        {
            cursoA[0] = 90; cursoB[0] = 60;
            cursoA[1] = 72; cursoB[1] = 100;
            cursoA[2] = 75; cursoB[2] = 60;
            cursoA[3] = 91; cursoB[3] = 100;
            cursoA[4] = 71; cursoB[4] = 90;
        }

        public void CalcularPromedio()
        {
            int total1 = 0;
            int total2 = 0;
            for (int i = 0; i < 5; i++)
            {
                total1 = cursoA[i] + total1;
                total2 = cursoB[i] + total2;

            }

            total1 = total1 / 5;
            total2 = total2 / 5;

            if (total1 > total2)
            {
                Console.WriteLine("El curso A tiene el promedio mas alto: " + total1);
                Console.WriteLine("Curso A " + total1);
                Console.WriteLine("Curso B " + total2);
            }
            else
            {
                Console.WriteLine("El curso B tiene el promedio mas alto: " + total2);
                Console.WriteLine("Curso A " + total1);
                Console.WriteLine("Curso B " + total2);
            }
        }
    }
}
