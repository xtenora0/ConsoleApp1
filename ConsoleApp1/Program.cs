// See https://aka.ms/new-console-template for more information

//string name = "";

//Console.WriteLine("Jak se jmenujes?");
//name = Console.ReadLine();

//switch (name) 
//{
//    case "Lukas":
//        Console.WriteLine("Ahoj Lukasi");
//        break;
//    case "Karel":
//        Console.WriteLine("Ahoj Karle");
//        break;
//    case "Tomas":
//        Console.WriteLine("Ahoj Tomasi");
//        break;
//    case "Martin":
//        Console.WriteLine("Ahoj Martine");
//        break;
//    case "Radim":
//        Console.WriteLine("Ahoj Radime");
//        break;
//    case "Jakub":
//        Console.WriteLine("Ahoj Jakube");
//        break;
//    case "Sofian":
//        Console.WriteLine("Ahoj Sofiane");
//        break;
//    default:
//        Console.WriteLine("Neznam te");
//        break;

//}

using ConsoleApp1;

Zvire zvire1 = new Zvire(Druh.KOCKA, "Morek");
zvire1.RekniCoJsi();
Zvire zvire2 = new Zvire(Druh.PES, "Hafan");
zvire2.RekniCoJsi();
Zvire zvire3 = new Zvire();
zvire3.RekniCoJsi();
Zvire zvire4 = new Zvire()
{
    Jmeno = "Alik",
    Druh = Druh.PES,
};
zvire4.RekniCoJsi();
Console.WriteLine($"Zvire 1: \nJmeno: {zvire1.Jmeno}\nDruh: {zvire1.Druh}");
zvire2.ToString();