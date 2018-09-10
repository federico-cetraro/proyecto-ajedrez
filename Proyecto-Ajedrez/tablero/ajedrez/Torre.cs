using tablero;

namespace ajedrez
{
    class Torre : Pieza
    {

        public Torre(Color color, Tablero tab) : base(color, tab)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}