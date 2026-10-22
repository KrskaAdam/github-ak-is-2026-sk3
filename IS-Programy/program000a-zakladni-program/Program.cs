
string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@ nazav program @@@@@");
Console.WriteLine("@@@@@@@@ Adam Krška @@@@@@@@");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("");
/*
Console.Write("       _..----.._");
Console.Write("    _-'_..----.._'-_");
Console.Write("  .'.  \       ( `'.'.");
Console.Write(" / / `\ `\       )  \ \");
Console.Write("| |   _`\ `\____(    | |");
Console.Write("| |  [__]_\ `\__()   | |");
Console.Write("| |        `\ `\     | |");
Console.Write(" \ \         `\ `\  / /");
Console.Write("  '.'-._       `\ `'.'");
Console.Write("    `-._`'----'`_.-' ");
Console.Write["        `"----"`"];
*/

      

 





 // vstup pocatecni hodnoty
Console.Write("Zadejte prvni cislo rady ");
int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("nezadali jse cele cislo. Zadejte prvni cislo rady znovu. ");
    }

     // vstup posledni hodnoty
Console.Write("Zadejte posledni cislo rady");
int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("nezadali jse cele cislo. Zadejte posledni cislo rady znovu.  ");
    }

     // vstup diferenci
Console.Write("Zadejte diferenci");

// Rekapitulace zadanych hodnot 
Console.WriteLine();
Console.WriteLine("=========================");
//Console.WriteLine($" Prvni cislo rady:{first}");
//Console.WriteLine($" Posledni cislo rady:{last}");
//Console.WriteLine($" Diference(krok):{step}");

//vypast na jeden radek
Console.WriteLine($"Prvni cislo rady:{first} Posledni cislo rady:{last} Diference(krok):{step}  ");


Console.WriteLine("=========================");
Console.WriteLine();
    
        


// Dotaz smerem k uziteli na opakovani 
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Pro opakovani programu stisknete pismeno A, nasledne stisknete Enter ");
Console.WriteLine("Jakoukliv jinou klavesou pro ukonceni programu   ");
Console.WriteLine();
Console.WriteLine("Chcete program opakovat? ");
again = Console.ReadLine() ?? "";
}


