int i;
double mayor, n, sum=0, p;
mayor = 0;

for (i = 1; i <= 25; i++)
{
    Console.WriteLine("Ingrese la nota de el alumno: " + i);
    n = double.Parse(Console.ReadLine());
    sum = sum + n;

    if (i == 1 || mayor < n)
        mayor = n;
    Console.WriteLine();
}
p = sum / 25;
Console.WriteLine("Mayor calificación: " + mayor);
Console.WriteLine("\nLa calificacion media es: " + p);
