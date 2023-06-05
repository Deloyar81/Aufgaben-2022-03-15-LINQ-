
using System.Text.RegularExpressions;

Aufgabe1();
Aufgabe2();
Aufgabe3();

Console.ReadLine();


//Aufgabe 1
void Aufgabe1()
{
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

    Console.WriteLine("1. Alle Zahlen echt kleiner als 7");
    Console.WriteLine();

    var kleinerSieben = numbers.Where(x => x < 7);

    foreach(var kleiner in kleinerSieben)
    {
        Console.WriteLine(kleiner);
    }

    Console.WriteLine();

    Console.WriteLine("2. Alle geraden Zahlen");
    Console.WriteLine();

    var alleGeraden = numbers.Where(x => x % 2 == 0);

    foreach(var gerade in alleGeraden)
    {
        Console.WriteLine(gerade);
    }

    Console.WriteLine();

    Console.WriteLine("3. Alle einstelligen ungeraden Zahlen");
    Console.WriteLine();

    //var einstelligUndUngerae = numbers.Where(x => x < 10).Where(x => x % 2 == 1);

    //Alterantive
    var einstelligUndUngerae = numbers.Where(x => x < 10 && x % 2 == 1);

    foreach ( var einstellig in einstelligUndUngerae)
    {
        Console.WriteLine(einstellig);
    }

    Console.WriteLine();

    Console.WriteLine("4. Alle geraden Zahlen ab dem 6 Element (einschließlich) im Array");
    Console.WriteLine();

    var geradeAbSechs = numbers.Skip(5).Where(x => x % 2 == 0);

    foreach (var gerade in geradeAbSechs)
    {
        Console.WriteLine(gerade);
    }
    Console.WriteLine();
}

//Aufgabe2
void Aufgabe2()
{
    string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };

    Console.WriteLine("1.Alle „Zahlen“ die drei Zeichen lang sind");
    Console.WriteLine();

    var dreiZeichen = numbers.Where(x => x.Length == 3);

    foreach( var zeichen in dreiZeichen)
    {
        Console.WriteLine(zeichen);
    }
    Console.WriteLine();

    Console.WriteLine("2. Alle „Zahlen“ die ein „o“ enthalten");
    Console.WriteLine();

    var includeO = numbers.Where(x => Regex.IsMatch(x, @"o"));

    foreach( var include in includeO)
    {
        Console.WriteLine(include);
    }
    Console.WriteLine();

    Console.WriteLine("3.Alle „Zahlen“ die auf „teen“ enden");
    Console.WriteLine();

    var endTeen = numbers.Where(x => Regex.IsMatch(x, @"teen\b"));

    foreach (var zahl in endTeen)
    {
        Console.WriteLine(zahl);
    }
    Console.WriteLine();

    Console.WriteLine("4. Die Großbuchstabendarstellung aller „Zahlen“ die auf „teen“ enden");
    Console.WriteLine();

    var upperTeen = from n in endTeen //numbers
                    //where Regex.IsMatch(n, , @"teen\b")
                    select n.ToUpper();

    //Variante
    var upperTeen2 = numbers.Where(x => Regex.IsMatch(x, @"teen")).Select(x => x.ToUpper());

    foreach (var teen in upperTeen)
    {
        Console.WriteLine(teen);
    }
    Console.WriteLine();

    Console.WriteLine("5. Alle „Zahlen“ die „four“ enthalten");
    Console.WriteLine();

    var four = numbers.Where(x => Regex.IsMatch(x, @"four"));

    foreach (var element in four)
    {
        Console.WriteLine(element);
    }
    Console.WriteLine();
}

//Aufgabe3
void Aufgabe3()
{
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

    Console.WriteLine("1. Die Summe aller Werte im Array ");
    Console.WriteLine();

    var summe = numbers.Sum();

    Console.WriteLine(summe);
    Console.WriteLine();

    Console.WriteLine("2. Die kleinste Zahl");
    Console.WriteLine();

    var littleOne = numbers.Min();
    Console.WriteLine(littleOne);
    Console.WriteLine();

    Console.WriteLine("3. Die größte Zahl");
    Console.WriteLine();

    var bigOne = numbers.Max();
    Console.WriteLine(bigOne);
    Console.WriteLine();

    Console.WriteLine("4. Den Durchschnittswert");
    Console.WriteLine();

    var average = numbers.Average();
    Console.WriteLine(average);
    Console.WriteLine();

    Console.WriteLine("5. Die kleinste gerade Zahl");
    Console.WriteLine();

    var littleGerade = numbers.Where(x => x % 2 == 0).Min();
    Console.WriteLine(littleGerade);
    Console.WriteLine();

    Console.WriteLine("6. Die größte ungerade Zahl");
    Console.WriteLine();

    var bigUngerade = numbers.Where(x => x % 2 == 1).Max();

    Console.WriteLine("7. Die Summe aller geraden Zahlen");
    Console.WriteLine();

    var sumGerade = numbers.Where(x => x % 2 == 0).Sum();
    Console.WriteLine(sumGerade);
    Console.WriteLine();

    Console.WriteLine("8. Den Durchschnittswert aller ungeraden Zahlen");
    Console.WriteLine();

    var ungeradeAverage = numbers.Where(x => x % 2 == 1).Average();
    Console.WriteLine(ungeradeAverage);
    Console.WriteLine();
}