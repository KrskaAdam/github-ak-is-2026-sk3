// one line comment
/* multi line comment
 * multi line comment
 * multi line comment
 */

// opakovani programu 


string again = "a";
// .ToLower() - prevede vsechna pismena na mala
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("");
Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("@@@@@@@@ vypis rady @@@@@@@@");
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
int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step<=0 )
    {
        Console.Write("nezadali jse cele cislo. Zadejte posledni cislo rady znovu.  ");
    }

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
    if (first <= last)
    {
        int current = first;
        while(current <= last)
        {
            Console.Write($"{current};");
            
            //predchozi napsat skracene current = current + step;
            current+= step;
        }
    }
    else
    {
        Console.WriteLine("Radu nelze vypsat");
        Console.WriteLine("prvni cislo je vetsi nez posledni");
        Console.WriteLine("Tento program umi vypsat pouze vzestupnou radu");
    }
        


// Dotaz smerem k uziteli na opakovani 
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Pro opakovani programu stisknete pismeno A, nasledne stisknete Enter ");
Console.WriteLine("Jakoukliv jinou klavesou pro ukonceni programu   ");
Console.WriteLine();
Console.WriteLine("Chcete program opakovat? ");
again = Console.ReadLine() ?? "";
}


