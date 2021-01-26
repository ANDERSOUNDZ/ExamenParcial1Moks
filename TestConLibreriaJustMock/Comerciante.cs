using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaJustMock
{
    internal class Comerciante
    {

        public bool RecibirLaptops { get { return Laptops != null && Laptops.Any(); } }
        public List<string> Laptops { get; internal set; }
        public List<string> LaptopsReserva { get; internal set; }
        public bool ReservoLaptops { get { return LaptopsReserva != null && LaptopsReserva.Any(); } }

        internal void ComprarLaptops(Bodega bodega, int numeroLaptopsAComprar, string modeloLaptop)
        {
            if (bodega.LaptopsDisponibles(modeloLaptop) >= numeroLaptopsAComprar)
            {
                Laptops = bodega.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar);
            }
            else if (bodega.LaptopsDisponibles(modeloLaptop) <= numeroLaptopsAComprar)
            {
                LaptopsReserva = bodega.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar);
            }
            else
            {
                Laptops = bodega.GenerarRecibo(modeloLaptop, numeroLaptopsAComprar);
            } 
        }
    }
}