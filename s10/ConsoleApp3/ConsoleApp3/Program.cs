int s, t = 0, b;
double rt;
rt = t * 0.15;
s = 1200;
b = 200;

Console.WriteLine("Desea aplicar el bono? (1 = sí, 0 = no)");
string bs = Console.ReadLine();
b = int.Parse(bs);

if (b == 1)
{
    t = s + b;
    Console.WriteLine("Cuantos días faltó al trabajo?");
    string d = Console.ReadLine();
    int q = int.Parse(d);
    if (q < 1)
    {
        Console.WriteLine("El total de sueldo es de: " + t);
    }
    else
    {
        double m = t - rt;
        Console.WriteLine("El total de el sueldo es: " + m);
    }
}
else
{
    t = s;
    Console.WriteLine("Cuantos días faltó al trabajo?");
    string d = Console.ReadLine();
    int q = int.Parse(d);
    if (q < 1)
    {
        Console.WriteLine("El total de sueldo es de: " + s);
    }
    else
    {
        double m = t - rt;
        Console.WriteLine("El total de el sueldo es: " + m);
    }
}