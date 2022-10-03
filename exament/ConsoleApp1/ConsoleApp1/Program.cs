string salir, n;
int a = 1;
int x = 0, b = 0;

while (a != 0)
{
    Console.WriteLine("¿Hay un siguiente cliente?: \n");
    Console.WriteLine("1 = Sí");
    Console.WriteLine("0 = No");
    salir = Console.ReadLine();
    a = int.Parse(salir);
    Console.WriteLine("Ponga e si es extranjero o si n si es nacional o enter si ya terminó");
    n = Console.ReadLine();
    


    if (n == "e")
    {
        x = x + 1;
    }
    else if (n == "n")
    {
        b = b + 1;
    }

}
Console.WriteLine("El total de clientes atendidos son: "+ (x+b));
Console.WriteLine("El total de clientes Extranjeros atendidos son: " + x);
Console.WriteLine("El total de clientes Nacionales atendidos son: " + b);