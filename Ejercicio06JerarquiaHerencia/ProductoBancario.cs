using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio06JerarquiaHerencia
{
    public class ProductoBancario
    {
        private string Cliente { get; set; }

        protected double Saldo { get; set; }

        public int numProductos { get; set; }

        public ProductoBancario()
        {

        }

        void Imprimir()
        {
        }

        //Destructor
        ~ProductoBancario() { }
    }
}
