//En una empresa trabajan n empleados cuyos sueldos oscilan entre 100 y 500,realizar un programa que
//lea los sueldos que cobra cada empleado e informecuántos empleados cobran entre 100 y 300 y cuántos cobran más de 300.
//Además,el programa deberá informar el importe que gasta la empresa en sueldos al personal.

int n = 1, a=0, b=0;
string l, m;
float s, t = 0;

while (n != 0)
{
    Console.WriteLine("Que desea hacer: \n"); //genera un loop que se actualiza cada vez que se usa el insertar sueldo <--
    Console.WriteLine("1 = Ingresar sueldo");
    Console.WriteLine("0 = salir");
    l = Console.ReadLine();
    n = int.Parse(l);
    if (n == 1)
    {
        Console.WriteLine("Inserte sueldo:");
        m =  Console.ReadLine();
        s = int.Parse(m);
        if (s >= 100 && s <= 300)
        {
            a = a + 1;
            t = t + s;
        }
        else if (s > 300 && s <= 500)
        {
            b = b + 1;
            t = t + s;
        }
        else
        {
            Console.WriteLine("Valores no validos");
        }
    }
    Console.WriteLine("Cantidad de sueldos entre 100 s/ y 300 s/: " + a);
    Console.WriteLine("\nSueldos mayores a 300 s/ " + b);
    Console.WriteLine("\nEl total de dinero que la empresa gasta en sueldos es " + t + "\n");
}