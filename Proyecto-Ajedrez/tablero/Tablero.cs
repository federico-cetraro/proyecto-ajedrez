namespace tablero
{
    class Tablero
    {
        public int lineas { get; set;}
        public int columnas {get; set;}
        private Pieza[,] piezas;

        public Tablero(int lineas, int columnas)
        {
            this.lineas = lineas;
            this.columnas = columnas;
            piezas = new Pieza[lineas, columnas];
        }

        public Pieza pieza(int linea, int columna)
        {
            return piezas[linea, columna];
        }

        public Pieza pieza(Posicion pos)
        {
            return piezas[pos.linea, pos.columna];
        }

        public bool piezaColocada(Posicion pos)
        {
            validarPosicion(pos);
            return pieza(pos) != null;
        }

        public void colocarPiezas(Pieza p, Posicion pos)
        {
            if (piezaColocada(pos))
            {
                throw new ExcepcionTablero("Ya hay una pieza en el lugar que se esta intentando colocar");
            }
            piezas[pos.linea, pos.columna] = p;
            p.posicion = pos;
        }

        public bool posicionValida(Posicion pos)
        {
            if (pos.linea<0 || pos.linea>=lineas || pos.columna<0 || pos.columna>=columnas){
                return false;
            }
            return true;
        }

        public void validarPosicion(Posicion pos)
        {
            if (!posicionValida(pos))
            {
                throw new ExcepcionTablero("Posicion no valida");
            }
        }
    }
}
