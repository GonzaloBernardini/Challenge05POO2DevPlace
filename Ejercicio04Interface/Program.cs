using System;

namespace Ejercicio04Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(0);
            Console.WriteLine("Por favor ingrese una cantidad de combustible a cargar al coche nuevo");
            coche1.CargarNafta(Convert.ToInt32(Console.ReadLine()));
            coche1.Conducir();
            
        }
    }
}
