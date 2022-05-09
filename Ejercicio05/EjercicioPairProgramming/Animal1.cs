using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio05
{
    public partial class Animales
    {
        public int id { get; set; }

        public string Nombre { get; set; }

        public Animales(int i,string n)
        {
            this.id = i;
            this.Nombre = n;
        }

    }
}
