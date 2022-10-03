int z = 20;
double pago;

do
{
    z = z - 3;//17,14,11, 8, !!!!!!5<--
    pago = 10 * z;//170, 140, 110, 80, 50
}
while (z > 6);//-->falso!!!!
//paso 3
Console.WriteLine("El pago a realizar es: " + pago);