using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio04Interface
{
    public interface IVehiculo
    {
        void Conducir();

        bool CargarNafta(int cantidad);
    }
}
