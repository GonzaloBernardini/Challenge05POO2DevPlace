using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class Estudiante : Persona
    {
        public Estudiante(string a): base(a)
        {
            
        }
        

        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando");
        }

        public void VerEdad()
        {            
            Console.WriteLine($"Mi edad es de: {edad}");
        }

    }
}
