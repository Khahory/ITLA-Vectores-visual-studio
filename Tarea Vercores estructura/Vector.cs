using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_Vercores_estructura
{
    class Vector
    {
        private int[] numero = new int[9];

        public void ObtenerValor()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Digite el valor del vector numero: " + i);
                numero[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Listo"); Console.ReadKey();
        }

        public void MostraValor()
        {
            int total = 0;
            int total2 = 0;
            foreach (var item in numero)
            {
                total = item + total;
            }
            Console.WriteLine("El valor acumulado es: " + total);
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var item in numero)
            {
                if (item >= 36)
                    total2 = item + total2;
            }
            Console.WriteLine("El valor acumulado de los numeros mayores a 36 son: " + total2);
            Console.WriteLine("---------------------------------------------------------------");
            foreach (var item in numero)
            {
                if (item >= 50)
                    Console.WriteLine("Los valores mayores a 50 son: " + item);
            }
            Console.WriteLine("Listo"); Console.ReadKey();
        }
    }
}
