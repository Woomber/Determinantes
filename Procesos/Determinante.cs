using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Determinantes.Tipos;

namespace Determinantes.Procesos
{
    class Determinante
    {
        Matriz Original;

        public Determinante(Matriz original)
        {
            this.Original = original;
        }

        public int Resolver()
        {
            return Resolver(this.Original);
        }
        
        int Resolver(Matriz matriz)
        {
            int solución = 0;

            if (matriz.Size == 2)
                return matriz.Datos[0, 0] * matriz.Datos[1, 1] - matriz.Datos[1, 0] * matriz.Datos[0, 1];

            for(int i = 0; i < matriz.Size; i++)
            {
                solución += ((i % 2 == 0) ? 1 : -1) * matriz.CruceEn(i)* Resolver(matriz.CortarEn(i));
            }

            return solución;
        }

    }
}
