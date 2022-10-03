double saldo = 2000;
double retirar;


do
{
    Console.WriteLine("Tu saldo: " + saldo);
    Console.WriteLine("rETIRAR");
    retirar = double.Parse(Console.ReadLine());
    Console.WriteLine("---------------------");

    if (retirar > saldo || retirar < 0)
    {
        Console.WriteLine("No puedes retirar");
    }
    else
    {
        saldo = saldo - retirar;
    }
}
while(saldo != 0);
Console.WriteLine("Saldo" + saldo);
Console.ReadKey();