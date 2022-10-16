int a;

Console.WriteLine("Inserte su numero para saber si es par o impar");
a = int.Parse(Console.ReadLine());

if ((a % 2) == 0)
{
    Console.WriteLine("Es par");
}
else
{
    Console.WriteLine("Es impar");
}
