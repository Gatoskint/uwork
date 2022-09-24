float n = 0, nm = 0, ni, t, e = 0, b;
string l;
int a;

Console.WriteLine("Seleccione su opción: \n");
Console.WriteLine("1 = Ingresar estaturas: ");
Console.WriteLine("0 = Salir");
l = Console.ReadLine();
a = int.Parse(l);

while (a != 0)
{
    Console.WriteLine("Ingrese la cantidad de Estudiantes: ");
    t = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= t; i++)
    {
        Console.WriteLine("Ingrese la estatura de el alumno " + i + " en centímetros: ");
        ni = Convert.ToInt32(Console.ReadLine());
        e = e + ni;
        if (i == 1)
        {
            n = ni;
            nm = ni;
            Console.WriteLine("La estatura mayor es: " + n);
            Console.WriteLine("La estatura menor es: " + nm);
            Console.WriteLine("La estatura promedio es: " + e / t);
        }
        else
        {
            if (ni > n)
            {
                n = ni;
                Console.WriteLine("La estatura mayor es: " + n);
                Console.WriteLine("La estatura menor es: " + nm);
                Console.WriteLine("La estatura promedio es: " + e / t);
            }
            if (ni < nm)
            {
                nm = ni;
                Console.WriteLine("La estatura mayor es: " + n);
                Console.WriteLine("La estatura menor es: " + nm);
                Console.WriteLine("La estatura promedio es: " + e / t);
            }
        }
    }
    break;
}
//Console.WriteLine("La estatura promedio es: " + e / t);
