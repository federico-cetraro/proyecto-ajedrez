using System;

namespace tablero
{
    class ExcepcionTablero : Exception
    {
        public ExcepcionTablero (string msg): base(msg)
        {
        }
    }
}
