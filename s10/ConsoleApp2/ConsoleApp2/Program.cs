using Microsoft.VisualBasic;

Console.WriteLine("Cuantos alumnos desea registrar (si no desea registrar ponga 0)");
string al = Console.ReadLine();
int aln = int.Parse(al);
if (aln == 0)
{
    System.Environment.Exit(1);
}
Console.WriteLine("Bienvenido al colegio Albert Einstein.\n");
Console.WriteLine("A que salón desea ir? A o B");
string b = Console.ReadLine();

if (b == "A" || b == "a")
{
    for (int i = 0; i < aln; i++)
    {
        Console.WriteLine("Ingrese su nombre");
        string a = Console.ReadLine();
        string pc2 = Strings.Left(a, 5);
        Console.WriteLine("Las 5 letras de lado izquierdo son: " + pc2);
    }

}
else
{
    for (int i = 0; i < aln; i++)
    {
        Console.WriteLine("Ingrese su nombre");
        string n = Console.ReadLine();
        string pc = Strings.Right(n, 4);
        Console.WriteLine("Las 5 letras de lado derecho son: " + pc);
    }
}
