using System;

string user, pass;
int o;

Console.WriteLine("***************************");
Console.WriteLine("*CAJERO AUTOMATICO MARCELO*");
Console.WriteLine("***************************");

Console.WriteLine("QUIERES LOGEAR?");
Console.WriteLine("1 sí; 0 No");
string r = Console.ReadLine();
o = int.Parse(r);


while (o == 1)
{
    Console.WriteLine("Ingrese su usuario");
    user = Console.ReadLine();
    int le = user.Length;
    Console.WriteLine("Ingrese su contraseña");
    pass = Console.ReadLine();
    int length = pass.Length;

    if (pass.Contains("12345") && user == "bob" && length <= 5 && le <= 3)
    {
        Console.WriteLine("Usuario correcto, ingresando al sistema... \n Presione cualquier tecla para continuar");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("*********************************************");
        Console.WriteLine("** CAJERO AUTOMATICO MARCELO **");
        Console.WriteLine("*********************************************");
        Console.WriteLine("\nSeleccione la operación que desea realizar :");

        Console.WriteLine("1.- Transferencia");
        Console.WriteLine("2.- Estado de cuenta");
        Console.WriteLine("3.- Depósito");
        Console.WriteLine("4.- Retiro");
        Console.WriteLine("5.- Salir.");
        Console.WriteLine("-----------------------------------------------------------------");
        string op = Console.ReadLine();
        int pp = int.Parse(op);

        switch (pp)
        {
            case 1:
                Console.WriteLine("Transferencia");
                break;
            case 2:
                Console.WriteLine("Consulta");
                break;
            case 3:
                Console.WriteLine("Deposito");
                break;
            case 4:
                Console.WriteLine("Retiro");
                break;
                default: System.Environment.Exit(1);
                break;

        }
        break;
    }
    else
    {
        Console.WriteLine("Usuario incorrecto!");
    }



    //USER LOGIN - PASS

}