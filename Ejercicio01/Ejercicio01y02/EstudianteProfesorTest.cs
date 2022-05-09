using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    class EstudianteProfesorTest
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Bienvenido, a continuacion elija una opcion:\n1.Crear una persona.\n2.Crear un estudiante.\n3.Crear un Profesor.\nPulse cualquier otra tecla para salir.");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1 || x==2 || x==3)
            {
                switch (x)
                {
                    case 1:
                        Persona p1 = new Persona();
                        p1.Saludar();
                        break;
                    case 2:
                        Estudiante e1 = new Estudiante();
                        Console.WriteLine("Introduzca una edad para el nuevo estudiante");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        e1.setEdad(edad);
                        e1.Saludar();
                        e1.VerEdad();
                        e1.Estudiar();
                        break;
                    case 3:
                        Profesor prof1 = new Profesor();
                        Console.WriteLine("Introduzca una edad para el nuevo estudiante");
                        edad = Convert.ToInt32(Console.ReadLine());
                        prof1.setEdad(edad);
                        prof1.Saludar();
                        prof1.Explicar();
                        break;
                    default:

                        break;
                }
            }
            else
            {
                Console.WriteLine("Gracias por utilizar el servicio para crear personas.Vuelva pronto!");
            }
            Console.ReadKey();
            */

            Persona[] arrayPersonas = new Persona[3];

            Console.WriteLine("Por favor ingrese tres nombres para personas a continuacion:");
            for (int i = 0; i < arrayPersonas.Length; i++)
            {
                
                if (i == 0 || i == 1)
                {
                    Console.WriteLine("Introduzca el nombre para el estudiante");
                    string nombrEst = Console.ReadLine();
                    
                    arrayPersonas[i] = new Estudiante(nombrEst);
                }
                else
                {
                    Console.WriteLine("Introduzca el nombre para el profesor");
                    string nombrProf = Console.ReadLine();
                    
                    arrayPersonas[i] = new Profesor(nombrProf);
                }
                
            }

            for (int i = 0; i < arrayPersonas.Length; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(arrayPersonas[i].ToString());
                    ((Profesor)arrayPersonas[i]).Explicar();
                }
                else
                {
                    Console.WriteLine(arrayPersonas[i].ToString());
                    ((Estudiante)arrayPersonas[i]).Estudiar();
                }

            }
        }



    }
}
