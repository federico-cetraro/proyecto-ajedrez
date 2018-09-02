﻿namespace tablero
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
    }
}