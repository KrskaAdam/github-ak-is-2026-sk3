
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

      

 





// Vstup pro počet generovaných čísel
    Console.Write("Zadejte počet generovaných čísel (kladné celé číslo): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n) || n<=0 )
    {
        Console.Write("Nezadali jste celé kladné celé číslo! Zadejte počet čísel znovu: ");
    }

    // Vstup pro dolní mez
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;
    while(!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte dolní mez znovu: ");
    }

    // Vstup pro horní mez
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě pro dolní mez): ");
    int upperBound;
    while(!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo nebo je horní mez menší než dolní mez! Zadejte horní mez znovu: ");
    }

// Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("==================================");
    // Výpis zadaných hodnot do jednoho řádku
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("==================================");
    Console.WriteLine();    

// Rekapitulace zadanych hodnot 
Console.WriteLine();
Console.WriteLine("=========================");
//Console.WriteLine($" Prvni cislo rady:{first}");
//Console.WriteLine($" Posledni cislo rady:{last}");
//Console.WriteLine($" Diference(krok):{step}");




Console.WriteLine("=========================");
Console.WriteLine();
    


    // Začátek konkrétního algoritmu

    // Deklarace pole a jeho alokace v paměti
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru náhodných čísel
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50); // Pevný seed pro testovací účely (vždy stejná čísla)

    Console.WriteLine("Generovaná čísla: ");
    for(int i = 0; i < myRandNumbs.Length; i++ )
    {
        // Generování i-tého náhodného čísla
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write($"{myRandNumbs[i]}; ");
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


