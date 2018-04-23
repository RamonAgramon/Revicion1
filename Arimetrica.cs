using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Arimetrica
    {
        public int Suma(int[] Numeros)
        {
            int Suma = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                Suma = Suma + Numeros[i];
            }
            return Suma;
        }
        public double Promedio(double[] Numeros)
        {
            double Suma = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                Suma = Suma + Numeros[i];
            }
            return (Suma / Numeros.Length);
        }
        public int Moda(int[] Numeros)
        {
            int Numero = 0;
            int[] auxiliar = new int[10];
            int posicion = 0;
            int Mayor = 0;
            int PosicionMayor = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                auxiliar[i] = 0;
            }
            for (int x = 0; x < Numeros.Length; x++)
            {
                Numero = Numeros[x];
                posicion = x;
                for (int y = 0; y < Numeros.Length; y++)
                {
                    if (Numeros[y] == Numero)
                    {
                        auxiliar[posicion]++;
                    }
                }
            }
            Mayor = auxiliar[0];
            PosicionMayor = 0;
            for (int i = 0; i < Numeros.Length; i++)
            {
                if (auxiliar[i] > Mayor)
                {
                    PosicionMayor = i;
                    Mayor = auxiliar[i];
                }
            }
            return Numeros[PosicionMayor];
        }
        public int Mediana(int[] Numeros)
        {

            return (Numeros[Numeros.Length / 2]);
        }
    }
}
