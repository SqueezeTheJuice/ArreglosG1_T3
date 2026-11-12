using System;

namespace Arreglos_Biblioteca
{
    public class Arreglo1
    {
        // Atributos o campos
        public int _tope;
        public int[] _arreglo;

        // Constructor
        public Arreglo1(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }

        // Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        // Métodos
        public void Llenar()
        {
            Llenar(1, 100);
        }

        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }
            _tope = N;
        }

        public void Ordenar()
        {
            Ordenar(true);
        }

        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] < _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                }
            }
        }

        public void Cambiar(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        public void Agregar(int n)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo está lleno");
            }
            _arreglo[_tope] = n;
            _tope++;
        }

        public void Insertar(int num, int posicion)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo está lleno");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }

            // Corregido: i-- y _arreglo[i - 1]
            for (int i = _tope; i > posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1];
            }
            _arreglo[posicion] = num;
            _tope++;
        }

        public Arreglo1 ObtenerPares()
        {
            int contadorPares = 0;
            for (int i = 0; i < _tope; i++)
            {
                if (EsPar(_arreglo[i]))
                {
                    contadorPares++;
                }
            }

            var arregloPares = new Arreglo1(contadorPares);
            for (int i = 0; i < _tope; i++)
            {
                if (EsPar(_arreglo[i]))
                {
                    arregloPares.Agregar(_arreglo[i]);
                }
            }
            return arregloPares;
        }

        private bool EsPar(int n)
        {
            return n % 2 == 0;
        }

        public Arreglo1 ObtenerPrimos()
        {
            int contadorPrimos = 0;
            // Primer ciclo cerrado correctamente antes de crear el nuevo arreglo
            for (int i = 0; i < _tope; i++)
            {
                if (EsPrimo(_arreglo[i]))
                {
                    contadorPrimos++;
                }
            }

            var arregloPrimos = new Arreglo1(contadorPrimos);
            for (int i = 0; i < _tope; i++)
            {
                if (EsPrimo(_arreglo[i]))
                {
                    arregloPrimos.Agregar(_arreglo[i]);
                }
            }
            return arregloPrimos;
        }

        private bool EsPrimo(int n)
        {
            if (n <= 1) return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void Eliminar(int posicion)
        {
            if (EstaVacio)
            {
                throw new Exception("El arreglo está vacío");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion >= _tope)
            {
                posicion = _tope - 1;
            }

            for (int i = posicion; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;
        }

        // Método ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "Está vacío";
            }

            string cadena = string.Empty;
            int contador = 0;

            // Corregido: i < _tope (sin el - 1) para incluir el último elemento
            for (int i = 0; i < _tope; i++)
            {
                cadena += $"{_arreglo[i]}\t";
                contador++;
                if (contador > 9)
                {
                    cadena += "\n";
                    contador = 0;
                }
            }
            return cadena;
        }
    }
}