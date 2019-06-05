using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4_Tarea_Vectores_estructura
{
    class Vector
    {
        private int[] elemento = new int[10];
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
            foreach (var item in elemento)
            {
                
            }
        }
    }
}
