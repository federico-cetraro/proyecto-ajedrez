using tablero;

namespace ajedrez
{
    class Rey:Pieza
    {

        public Rey(Color color, Tablero tab) : base(color, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
