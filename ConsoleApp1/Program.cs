// See https://aka.ms/new-console-template for more information

string name = "";

Console.WriteLine("Jak se jmenujes?");
name = Console.ReadLine();

switch (name) 
{
    case "Lukas":
        Console.WriteLine("Ahoj Lukasi");
        break;
    case "Karel":
        Console.WriteLine("Ahoj Karle");
        break;
    case "Tomas":
        Console.WriteLine("Ahoj Tomasi");
        break;
    case "Martin":
        Console.WriteLine("Ahoj Martine");
        break;
    case "Radim":
        Console.WriteLine("Ahoj Radime");
        break;
    case "Jakub":
        Console.WriteLine("Ahoj Jakube");
        break;
    case "Sofian":
        Console.WriteLine("Ahoj Sofiane");
        break;
    default:
        Console.WriteLine("Neznam te");
        break;

}
