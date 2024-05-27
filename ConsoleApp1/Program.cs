// See https://aka.ms/new-console-template for more information

//string[] jmena = ["Lukáš", "Karel", "Tomáš", "Martin", "Radim", "Jakub", "Sofián", "Pavel", "Petr"];

//List<string> listJmena = new List<string>() {
//    "Lukáš", "Karel", "Tomáš", "Martin", "Radim", "Jakub", "Sofián", "Pavel", "Petr"
//};

//List<string> listJmena2 = ["Lukáš", "Karel", "Tomáš", "Martin", "Radim", 
//    "Jakub", "Sofián", "Pavel", "Petr"];

//List<string> listJmena3 = new(){"Lukáš", "Karel", "Tomáš", "Martin", "Radim",
//    "Jakub", "Sofián", "Pavel", "Petr"};

//listJmena.Add("Ester");

//Console.WriteLine("Pocet lidi v seznamu: " + listJmena.Count);
//foreach (var item in listJmena) 
//{
//    Console.WriteLine(item + " pocet pismen: " + item.Length);
//}

//Dictionary<int, string> dnyVTydnu = new Dictionary<int, string>() 
//{
//    {1, "Pondeli" },
//    {2, "Utery" },
//    {3, "Streda" },
//    {4, "Ctvrtek" },
//    {5, "Patek" },
//    {6, "Sobota" },
//    {7, "Nedele" },
//};

//var streda = dnyVTydnu[3];

Dictionary<string, string> jmenaPozdravy = new Dictionary<string, string>()
{
    {"Lukas", "Lukasi" },
    {"Karel", "Karle" },
    {"Tomas", "Tomasi" },
    {"Martin", "Martine" },
    {"Radim", "Radime" },
    {"Jakub", "Jakube" },
    {"Sofian", "Sofiane" },
};

Console.WriteLine("Jak se jmenujes?");
string jmeno = Console.ReadLine();

switch (jmeno)
{
    case "Lukas":
        Console.WriteLine("Ahoj " + jmenaPozdravy[jmeno]);
        break;
    case "Karel":
        Console.WriteLine("Ahoj " + jmenaPozdravy[jmeno]);
        break;
    case "Tomas":
        Console.WriteLine("Ahoj " + jmenaPozdravy[jmeno]);
        break;
    case "Martin":
        Console.WriteLine("Ahoj " + jmenaPozdravy[jmeno]);
        break;
    case "Radim":
        Console.WriteLine("Ahoj " + jmenaPozdravy[jmeno]);
        break;
    case "Jakub":
        Console.WriteLine("Ahoj " + jmenaPozdravy[jmeno]);
        break;
    case "Sofian":
        Console.WriteLine("Ahoj " + jmenaPozdravy[jmeno]);
        break;
    default:
        Console.WriteLine("Neznam te");
        break;

}


//for(int i = 0; i < jmena.Length; i++) 
//{
//    var jmeno = jmena[i];
//    Console.WriteLine(jmeno);
//}

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

//using ConsoleApp1;

//Zvire zvire1 = new Zvire(Druh.KOCKA, "Morek");
//zvire1.RekniCoJsi();
//Zvire zvire2 = new Zvire(Druh.PES, "Hafan");
//zvire2.RekniCoJsi();
//Zvire zvire3 = new Zvire();
//zvire3.RekniCoJsi();
//Zvire zvire4 = new Zvire()
//{
//    Jmeno = "Alik",
//    Druh = Druh.PES,
//};
//zvire4.RekniCoJsi();
//Console.WriteLine($"Zvire 1: \nJmeno: {zvire1.Jmeno}\nDruh: {zvire1.Druh}");
//zvire2.ToString();