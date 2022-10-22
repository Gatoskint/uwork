using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class saved
    {
        public string nombre, apellido, edad, dni;


        public void datos()
        {
            Console.WriteLine("Inserte su Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Inserte su Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Inserte su Edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar su DNI: ");
            int dni = int.Parse(Console.ReadLine());

            if (edad >= 16)
            {
                Console.WriteLine("Usted es mayor de edad");
                Console.WriteLine("Los datos son: " + nombre + " " + apellido + " " + edad + " " + dni);
            }
            else
            {
                Console.WriteLine("Usted aun no es mayor de edad");
                Console.WriteLine("Los datos son: " + nombre + " " + apellido + " " + edad + " " + dni);
            }
        }
    }
}