using System.Collections.Generic;

namespace PruebaJustMock
{
    public abstract class Bodega
    {
        public abstract int LaptopsDisponibles(string modeloLaptop);
        public abstract List<string> GenerarRecibo(string modeloLaptop, int numeroLaptopsAComprar);
    }
}