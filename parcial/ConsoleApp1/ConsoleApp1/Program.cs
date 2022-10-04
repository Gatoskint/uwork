string l, a;
int n, h;
double ht;

Console.WriteLine("Inserte numero de trabajadores: ");
l = Console.ReadLine();
n = int.Parse(l);

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Ingrese el area de trabajo: ");
    a = Console.ReadLine();
    Console.WriteLine("Ingrese las horas trabajadas: ");
    h=int.Parse(Console.ReadLine());

    if (a == "Contabilidad" || a == "contabilidad")
    {
        ht = h * 40;
        Console.WriteLine("El sueldo total por las horas trabajadas es: " + ht);
    }
    else if (a == "marketing" || a == "Marketing")
    {
        ht = h * 30;
        Console.WriteLine("El sueldo total por las horas trabajadas es: " + ht);
    }
}

