using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos_Biblioteca
{
    internal class Arreglo1
    {



        public void Ordenar()
        {
            Ordenar(true);
        }


        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i +1;j < _tope; j++)
                {
                    if (ascendente)
                    {

                    }
                    if (_arreglo[i] > _arreglo[j])
                        {
                         Cambiar(_arreglo[i], _arreglo[j]);
                        }
                    
                }
            }
        }


        public void Cambiar(int a, int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
    }
}
