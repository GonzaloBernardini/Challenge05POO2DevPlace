using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class Persona
    {
        protected int edad;

        protected string nombre;
        
        public Persona()
        {
            
            
        }
        public Persona(string name)
        {
            nombre = name;
        }
        public override string ToString() 
        {
            return  "Nombre :"+ nombre + " " + "Edad :" + edad;
        }

        public void Saludar()
        {
            Console.WriteLine("Estoy saludando!");
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public void getEdad()
        {
            Console.WriteLine(edad);
        }

    }
}
