
string xit, n, lista;
int a = 1, b, s=1;

Console.WriteLine("\\______   \\__| ____   _______  __ ____   ____ |__| __| _/____  ______       ");
Console.WriteLine(" |    |  _/  |/ __ \\ /    \\  \\/ // __ \\ /    \\|  |/ __ |/  _ \\/  ___/       \r\n");
Console.WriteLine(" |    |   \\  \\  ___/|   |  \\   /\\  ___/|   |  \\  / /_/ (  <_> )___ \\ ");
Console.WriteLine(" |______  /__|\\___  >___|  /\\_/  \\___  >___|  /__\\____ |\\____/____  > ");
Console.WriteLine("       \\/        \\/     \\/          \\/     \\/        \\/          \\/");

while (a != 0)
{
    Console.WriteLine("seleccione lo que desea hacer: ");
    Console.WriteLine("1: Comprar");
    Console.WriteLine("0: Salir");
    xit = Console.ReadLine(); //loop tipico con while para el menu principal
    a = int.Parse(xit);
    if (a == 0)
    {
        Environment.Exit(0);
    }

    Console.WriteLine("Seleccione el apartado que desea: ");
    Console.WriteLine("0: Frutas y verduras. 1: Golosinas. 2: Abarrotes");
    n = Console.ReadLine(); //leer el apartado para que se cumplan los casos del switch
    b = int.Parse(n);

    switch (b)
    {
        case 0:
            Console.WriteLine("Que desea comprar? escribalo con una coma");
            Console.WriteLine("Peras (5/s el kilo");
            Console.WriteLine("Manzanas");
            Console.WriteLine("Tomates");
            Console.WriteLine("Lechuga");
            Console.WriteLine("Col");
            Console.WriteLine("Pepinillos");
            Console.WriteLine("Ajos");
            Console.WriteLine("Cebolla");
            Console.WriteLine("Kion");
            Console.WriteLine("Papaya");
            Console.WriteLine("Fresa");
            Console.WriteLine("Palta");
            lista = Console.ReadLine();
            Console.WriteLine("Su lista de compras es: " + lista);
            Console.WriteLine("El total es: " + s);
            break;
            case 1:
            Console.WriteLine("Que desea comprar? escribalo con una coma");
            Console.WriteLine("Papas 'Lays'");
            Console.WriteLine("Papas 'InkaChips'");
            Console.WriteLine("Orea");
            Console.WriteLine("Cifrut");
            Console.WriteLine("Inka Cola");
            Console.WriteLine("Coca Cola");
            Console.WriteLine("Guaraná");
            Console.WriteLine("Galleta 'Soda'");
            Console.WriteLine("Galleta 'Casino'");
            Console.WriteLine("Agua Cielo");
            Console.WriteLine("Galleta 'Glacitas'");
            Console.WriteLine("Frugos");
            Console.WriteLine("Cheetos");
            lista = Console.ReadLine();
            Console.WriteLine("Su lista de compras es: " + lista);
            Console.WriteLine("El total es: " + s);
            break;
            case 2:
            Console.WriteLine("Que desea comprar? escribalo con una coma");
            Console.WriteLine("Huevos");
            Console.WriteLine("Cereales 'nocaritas'");
            Console.WriteLine("Café 'niscafe'");
            Console.WriteLine("Atún 'primero'");
            Console.WriteLine("Fideos 'Don italia'");
            Console.WriteLine("Arroz");
            Console.WriteLine("Azucar");
            Console.WriteLine("Sal");
            Console.WriteLine("Leche 'Miseria'");
            Console.WriteLine("Papel higienico 'elita'");
            Console.WriteLine("Cerveaz 'pilsan'");
            lista = Console.ReadLine();
            Console.WriteLine("Su lista de compras es: " + lista);
            Console.WriteLine("El total es: " + s);
            break;
    }
    Console.WriteLine();
    //Cancelación ------------->
}