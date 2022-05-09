using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 05 Completo
            Console.WriteLine("Introduzca un nombre para su nuevo perro: ");
            string entrada = Console.ReadLine();
            Perro perrito = new Perro();
            perrito.Nombre = entrada;
            Console.WriteLine("El nombre de su perrito ahora es: " + perrito.GetNombre());
            
            perrito.Comer();

            //Probando el ejercicio pair programming 05 clases parciales
            Console.WriteLine("Ingrese un id para el animal");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un nombre de animaless");
            string nombreAnimal = Console.ReadLine(); 

            Animales nuevito = new Animales(id,nombreAnimal);


        }

    }
    abstract class Animal
    {
        public string Nombre;

        public string SetNombre(string nomb)
        {
            Nombre = nomb;
            return Nombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public abstract void Comer();
        
    }
    class Perro : Animal
    {
        public override void Comer()
        {
            Console.WriteLine("Estoy comiendo");            
        }
    }
    
}
