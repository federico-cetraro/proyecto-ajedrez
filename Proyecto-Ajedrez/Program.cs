using System;
using tablero;

namespace Proyecto_Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {

            Tablero tab = new Tablero(8, 8);

            Pantalla.mostrarTablero(tab);

            Console.ReadLine();

        }
    }
}
