//Ejercicio 1 - IF
const double desc10 = 0.1;
const double desc20 = 0.2;
const double desc30 = 0.3;
const double desc40 = 0.4;


double kitkat = 2.15;
double mm = 1.15;
double cokeZero = .95;

double productos = kitkat + mm + cokeZero;


Console.WriteLine("Articulos a comprar....");


Console.WriteLine("Kit-kat $2.15");
Console.WriteLine("M & M's $1.15");
Console.WriteLine("CocaCola Zero $0.95");



Console.WriteLine("Inrgese un nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Inrgese un email: ");
string email = Console.ReadLine();
Console.WriteLine("¿Posee algun cupon de descuento? (S/N): ");
char opc = char.Parse(Console.ReadLine().ToUpper());


if (opc == 'S') 
{
    Console.WriteLine("Elija cuanto es la cantidad de descuento de su cupon:");
    Console.WriteLine("1. 10%");
    Console.WriteLine("2. 20%");
    Console.WriteLine("3. 30%");
    Console.WriteLine("4. 40%");
    Console.WriteLine("Ingrese su opcion: ");

    int opc2 = Int32.Parse(Console.ReadLine());
    double desc;
    

    if (opc2 == 1) 
    {
        desc = productos - (productos * desc10);
        Console.WriteLine($"El total a pagar por los productos es de ${desc}. Precio anterior {productos}");
    }
    if (opc2 == 2)
    {
        desc = productos - (productos * desc20);
        Console.WriteLine($"El total a pagar por los productos es de ${desc}. Precio anterior {productos}");
    }
    if (opc2 == 3)
    {
        desc = productos - (productos * desc30);
        Console.WriteLine($"El total a pagar por los productos es de ${desc}. Precio anterior {productos}");
    }
    if (opc2 == 4)
    {
        desc = productos - (productos * desc40);
        Console.WriteLine($"El total a pagar por los productos es de ${desc}. Precio anterior {productos}");
    }



}else Console.WriteLine($"No tiene cupon de descuento, el total a pagar es de ${productos}");



//Ejercicio 2 - Switch

string[] lenguajes = { "C#", "Java", "Python", "JavaScript" };

Console.WriteLine("Seleccione un lenguaje de programación:");
for (int i = 0; i < lenguajes.Length; i++)
{
    Console.WriteLine($"{i + 1}. {lenguajes[i]}");
}

int opcion = int.Parse(Console.ReadLine());

if (opcion >= 1 && opcion <= lenguajes.Length)
{
    string lenguajeSeleccionado = lenguajes[opcion - 1];
    string holaMundo = "";

    switch (lenguajeSeleccionado)
    {
        case "C#":
            holaMundo = "Console.WriteLine(\"Hola, mundo\");";
            break;

        case "Java":
            holaMundo = "System.out.println(\"Hola, mundo\");";
            break;

        case "Python":
            holaMundo = "print(\"Hola, mundo\")";
            break;

        case "JavaScript":
            holaMundo = "console.log(\"Hola, mundo\");";
            break;

        default:
            Console.WriteLine("Lenguaje no reconocido");
            return;
    }

    Console.WriteLine($"Hola, mundo en {lenguajeSeleccionado}: {holaMundo}");
}
else
{
    Console.WriteLine("Opción inválida. Saliendo del programa.");
}


