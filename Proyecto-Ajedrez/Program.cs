using System;
using tablero;
using ajedrez;

namespace Proyecto_Ajedrez
{
    class Program
    {
        static void Main(string[] args)
        {

            Tablero tab = new Tablero(8, 8);

            tab.colocarPiezas(new Rey(Color.Negro, tab), new Posicion(1, 2));
            tab.colocarPiezas(new Torre(Color.Negro, tab), new Posicion(1, 5));
            tab.colocarPiezas(new Torre(Color.Blanco, tab), new Posicion(3, 2));
            tab.colocarPiezas(new Rey(Color.Blanco, tab), new Posicion(3, 1));

            Pantalla.mostrarTablero(tab);

            Console.ReadLine();

        }
    }
}
