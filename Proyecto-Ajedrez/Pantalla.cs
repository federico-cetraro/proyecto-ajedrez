using System;
using tablero;

namespace Proyecto_Ajedrez
{
    class Pantalla
    {
        public static void mostrarTablero(Tablero tab)
        {
            for (int i = 0; i<tab.lineas; i++)
            {
                for (int j=0; j<tab.columnas; j++)
                {
                    if (tab.pieza(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.pieza(i, j) + " ");
                    }
                }Console.WriteLine();
            }
        }

        

    }
}
