//Una planta que fabrica perfiles de hierro posee un lote de n piezas.
//Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego ingrese la longitud de cada perfil;
//sabiendo que la pieza cuya longitud esté comprendida en el rango de 1.20 y 1.30 son aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote

 
int n = 1, c, p = 0;
float lo;
string l;
Console.Write("Inserte la cantidad de piezas:\n");
l = Console.ReadLine();
c = int.Parse(l);
while (n <= c)
{
    Console.Write("Longitud de la pieza:\n");
    l = Console.ReadLine();
    lo = float.Parse(l);
if (lo >= 1.20 && lo <= 1.30)
{
    p = p + 1;
}
    n = n + 1;
}
Console.Write("Piezas aptas en el lote: " + p);

