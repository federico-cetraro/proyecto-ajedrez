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
                Console.Write(8 - i + " ");

                for (int j=0; j<tab.columnas; j++)
                {
                    if (tab.pieza(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        imprimirPiezas(tab.pieza(i, j));
                        Console.Write(" ");
                    }
                }Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPiezas(Pieza pieza)
        {
            if (pieza.color == Color.Blanco)
            {
                Console.Write(pieza);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(pieza);
                Console.ForegroundColor = aux;
            }
        }
        

    }
}
