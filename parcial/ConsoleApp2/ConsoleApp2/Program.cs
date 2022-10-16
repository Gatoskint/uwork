int n = 1, x=0, b, s=0,t=0, tt, a=0;

while (n != 0)
{
    Console.WriteLine("¿Desea registrar otro cliente?: \n");
    Console.WriteLine("1 = Si");
    Console.WriteLine("0 = No");
    n = int.Parse(Console.ReadLine());
    x = x + 1;
    if (n == 0)
    {
        System.Environment.Exit(1);
    }
    Console.WriteLine("Ingrese la cantidad de días de viaje");
    Console.ReadLine();
    Console.WriteLine("Costo total del viaje");
    tt = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la puntuacion de el 1 al 10");
    b = int.Parse(Console.ReadLine());
    a = a + tt;



    if (b <=10 && b >= 6)
    {
        s = s + 1;
    }
    if (b == 10)
    {
        t = t + 1;
    }
    if (t >= 1)
    {
        Console.WriteLine("Se obtuvo 1 mayor puntaje, tot: " + t);
    }
    Console.WriteLine("La cantidad de clientes con satisfacción entre 6 y 10 es de: " + s);
    Console.WriteLine("La cantidad total de clientes es de: " + x);
    Console.WriteLine("El monto total es de: " + a);
}