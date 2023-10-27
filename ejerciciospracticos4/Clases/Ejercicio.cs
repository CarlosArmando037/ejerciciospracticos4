using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospracticos4.Clases
{
    internal class Ejercicio
    {
        public void instrucciones()
        {
            // -------------------------------------------------------------------------a)
            int[,] t = new int[3, 4];

            //.------------------------------------------------------------------------- b)
            int filasT = t.GetLength(0);
            Console.WriteLine("Filas de t: " + filasT);

            // ------------------------------------------------------------------------c)
            int columnasT = t.GetLength(1);
            Console.WriteLine("Columnas de t: " + columnasT);

            // -------------------------------------------------------------------------d)
            int totalElementosT = t.Length;
            Console.WriteLine("Elementos de t: " + totalElementosT);

            // -------------------------------------------------------------------------e)
            for (int i = 0; i < columnasT; i++)
            {
                Console.WriteLine(t[0, i]);
            }

            // ------------------------------------------------------------------------f)
            for (int i = 0; i < filasT; i++)
            {
                Console.WriteLine(t[i, 1]);
            }

            // ------------------------------------------------------------------------g)
            t[0, 1] = 0;

            // -------------------------------------------------------------------------h)
            t[0, 0] = 0;
            t[0, 1] = 0;
            t[0, 2] = 0;
            t[0, 3] = 0;
            t[1, 0] = 0;
            t[1, 1] = 0;
            t[1, 2] = 0;
            t[1, 3] = 0;
            t[2, 0] = 0;
            t[2, 1] = 0;
            t[2, 2] = 0;
            t[2, 3] = 0;

            // --------------------------------------------------------------------------i)
            for (int i = 0; i < filasT; i++)
            {
                for (int j = 0; j < columnasT; j++)
                {
                    t[i, j] = 0;
                }
            }

            // --------------------------------------------------------------------------j) 
            for (int i = 0; i < filasT; i++)
            {
                for (int j = 0; j < columnasT; j++)
                {
                    Console.Write("Ingrese el valor para t[" + i + "," + j + "]: ");
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // --------------------------------------------------------------------------k) 
            int menor = t[0, 0];
            for (int i = 0; i < filasT; i++)
            {
                for (int j = 0; j < columnasT; j++)
                {
                    if (t[i, j] < menor)
                    {
                        menor = t[i, j];
                    }
                }
            }
            Console.WriteLine("El valor más pequeño en t es: " + menor);

            // ------------------------------------------------------------------------------l)
            for (int i = 0; i < columnasT; i++)
            {
                Console.Write(t[0, i] + " ");
            }
            Console.WriteLine();

            // ---------------------------------------------------------------------------m)
            int totalColumnaTres = 0;
            for (int i = 0; i < filasT; i++)
            {
                totalColumnaTres += t[i, 2];
            }
            Console.WriteLine("Total de la tercera columna: " + totalColumnaTres);

            // ---------------------------------------------------------------------------n)
            Console.Write("   ");
            for (int i = 0; i < columnasT; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < filasT; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < columnasT; j++)
                {
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
