namespace tablero
{
    class Posicion
    {
        public int linea { get; set; }
        public int columna { get; set; }

        public Posicion(int linea, int columna)
        {
            this.linea = linea;
            this.columna = columna;
        }

        public override string ToString()
        {
            return linea +
                ", " +
                columna;
        }

    }
}
