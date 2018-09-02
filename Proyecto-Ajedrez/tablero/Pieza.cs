namespace tablero
{
    class Pieza
    {
        public Posicion posicion {get; set;}
        public Color color { get; protected set; }
        public int cantMovimientos { get; protected set; }
        public Tablero tab { get; protected set; }

        public Pieza (Posicion posicion, Color color, Tablero tab)
        {
            this.posicion = posicion;
            this.color = color;
            this.tab = tab;
            this.cantMovimientos = 0;
        }

    }
}
