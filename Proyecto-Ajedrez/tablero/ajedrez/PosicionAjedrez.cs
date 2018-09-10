using System;
using tablero;

namespace ajedrez
{
    class PosicionAjedrez
    {
        public char columna { get; set; }
        public int linea { get; set; }

        public PosicionAjedrez(char columna, int linea)
        {
            this.columna = columna;
            this.linea = linea;
        }

        public Posicion toPosicion()
        {
            return new Posicion(8 - linea, columna - 'a');
        }

        public override string ToString()
        {
            return "" + columna + linea;
        }

    }
}
