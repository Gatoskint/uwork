using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class
    {
        public int s, m, g;
        
        public void producto()
        {
            Console.WriteLine("Ingrese el nombre de el producto: ");
            string nom = Console.ReadLine();
        }
        public void Precio()
        {
            Console.WriteLine("Ingrese la cantidad de el precio");
            int p = int.Parse(Console.ReadLine());
            s = p;
        }
        
        public void Cantidad()
        {
            Console.WriteLine("Ingrese la unidad de la cantidad");
            int c = int.Parse(Console.ReadLine());
            m = c;
        }
        public void total()
        {
            g = s * m;
            Console.WriteLine("El total es: "+ g);
        }
    }
}
