using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio04Interface
{
    class Coche
    {
        public int combustible { get; set; }

        public Coche(int gas)
        {
            combustible = gas;
        }

        public void Conducir()
        {
            if (combustible > 0)
            {
                Console.WriteLine("Estoy conduciendo");
            }
            else
            {
                Console.WriteLine("Necesito cargar combustible :'(");
            }
            
        }
        public bool CargarNafta(int cantidad)
        {
            combustible += cantidad;
            return true;
        }

    }
}
