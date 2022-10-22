using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    class Triangulo
    {
        private int lado1, lado2, lado3;
        private string linea;

        public void Inicializar()

        {
            Console.Write("ingrese el primer lado del triangulo: ");
            linea = Console.ReadLine();
            lado1 = int.Parse(linea);
            Console.Write("Ingrese el segundo lado del triangulo: ");
            linea = Console.ReadLine();
            lado2 = int.Parse(linea);
            Console.Write("Ingrese el tercer lado del triangulo: ");
            linea = Console.ReadLine();
            lado3 = int.Parse(linea);

        }

        public void Imprimir()
        {

            if (lado1 > lado2 && lado1 > lado3)
            {

                Console.Write("El Lado mayor es el lado 1 con: ");
                Console.WriteLine(lado1);
            }
            else
                if (lado2 > lado1 && lado2 > lado3)
            {
                Console.Write("El lado mayor es el lado 2 con: ");
                Console.WriteLine(lado2);
            }
            else
            {
                Console.WriteLine("el lado mayor es el lado 3 con:");
                Console.WriteLine(lado3);
            }


        }

        public void Equilatero()
        {

            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es un triangulo equilatero");
            }
            else
            {
                Console.WriteLine("No es un triangulo equilatero");
            }
            if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                Console.WriteLine("Es un triangulo isoceles");
            }
            else
            {
                Console.WriteLine("No es isoceles");
            }

        }
    }
}