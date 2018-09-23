using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Determinantes.Tipos
{
    class Matriz
    {
        public int[,] Datos { set; get; }
        public int Size { get; }
        public const int minSize = 2;
        public const int maxSize = 10;

        public Matriz(int size)
        {
            if (size < minSize || size > maxSize) throw new ArgumentOutOfRangeException();
            this.Size = size;
            Datos = new int[this.Size, this.Size];

        }

        public void Llenar(int[] datos)
        {
            int currDato = 0;

            if (datos.Length != this.Size * this.Size) throw new ArgumentOutOfRangeException();

            for (int i = 0; i < this.Size; i++)
                for (int j = 0; j < this.Size; j++)
                    this.Datos[i, j] = datos[currDato++];

        }

        public Matriz CortarEn(int index)
        {
            Matriz nueva = new Matriz(this.Size - 1);
            int currIndex = 0;
            int[] datos = new int[(this.Size - 1) * (this.Size - 1)];

            if (index >= this.Size || index < 0) throw new ArgumentOutOfRangeException();


            for (int i = 1; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    if (j == index) continue;
                    datos[currIndex++] = this.Datos[i, j];
                }
            }

            nueva.Llenar(datos);
            return nueva;
        }

        public int CruceEn(int index)
        {
            return Datos[0, index];
        }

        public override string ToString()
        {
            string cadena = "";
            for (int i = 0; i < this.Size; i++)
            {
                cadena += "|\t";
                for (int j = 0; j < this.Size; j++)
                {
                    cadena += this.Datos[i, j] + "\t";
                }
                cadena += "|\n";
            }
            return cadena;
        }

    }
}
