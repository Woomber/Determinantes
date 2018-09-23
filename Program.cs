using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Determinantes.Procesos;
using Determinantes.Tipos;

namespace Determinantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz Resolver;
            Determinante DeterminanteMatriz;
            int size;
            int[] elementos;

            while (true)
            {
                try
                {
                    Console.Write("Tamaño de la matriz ({0} a {1}): ", Matriz.minSize, Matriz.maxSize);
                    size = int.Parse(Console.ReadLine());
                    elementos = new int[size*size];
                    Resolver = new Matriz(size);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }//while

            for (int i = 0; i < size*size; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Elemento {0}: ", i + 1);
                        elementos[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }//for

            
            Resolver.Llenar(elementos);
            Console.WriteLine("\nMatriz a resolver:\n{0}", Resolver.ToString());

            DeterminanteMatriz = new Determinante(Resolver);
            Console.WriteLine("\nDeterminante: {0}", DeterminanteMatriz.Resolver());
            Console.ReadLine();

        }
    }
}
