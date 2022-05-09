using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class Profesor : Persona
    {
        public Profesor(string a): base(a)
        {

        }
        public void Explicar()
        {
            Console.WriteLine("Estoy explicando");
        }

    }
}
