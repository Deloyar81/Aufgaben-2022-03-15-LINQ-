using System.Diagnostics;

//Aufgabe1();
//Aufgabe2();
Aufgabe3();


Console.ReadLine();


static void Aufgabe1()
{
    string[] numbers ={ "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };


    Console.WriteLine("1. Gruppieren Sie die Worte im obigen Array nach dem Anfangsbuchstaben");

    var firstletter = numbers.GroupBy(word => word[0], word => word, (buchstabe, dieWörter) => new
    {
        Anfangsbuchstabe = buchstabe,
        Wörter = dieWörter
    });

    foreach (var gruppe in firstletter)
    {
        Console.WriteLine("'{0}'", gruppe.Anfangsbuchstabe);
            
        foreach(var word in gruppe.Wörter)
        {
            Console.WriteLine("{0}", word);
        }
    }
    Console.WriteLine();

    //Alternative:
    var g = numbers.GroupBy(wort => wort[0]);

    foreach (var gruppe in g)
    {
        Console.WriteLine("'{0}':", gruppe.Key);
        foreach (var wort in gruppe)
        {
            Console.WriteLine("{0}", wort);
        }
    }
    Console.WriteLine();

    Console.WriteLine("2. Gruppieren Sie die Worte im obigen Array nach der Länge");

    var länge = numbers.GroupBy(wort => wort.Length);

    foreach (var gruppe in länge)
    {
        Console.WriteLine("'{0}':", gruppe.Key);
        foreach (var wort in gruppe)
        {
            Console.WriteLine("{0}", wort);
        }
    }
    Console.WriteLine();

    Console.WriteLine("3. Gruppieren Sie die Worte im obigen Array nach dem Anfangsbuchstaben und der Länge");

    var längeUndAnfang = numbers.OrderBy(w => w[0]).GroupBy(w => new { firstletter = w[0], wordlength = w.Length },
                         w => w, (letter, word) => new { firstletter = letter.firstletter, wordlength = letter.wordlength, wörter = word });

    foreach(var gruppe in längeUndAnfang)
    {
        Console.WriteLine(gruppe.wordlength);
        Console.WriteLine(gruppe.firstletter);

        foreach(var word in gruppe.wörter)
        {
            Console.WriteLine(word);
        }
    }


    //Alternative?

                         //var längeUndAnfang = from einWort in numbers
                         //                     group einWort by einWort[0]
                         //                     into wortGruppe
                         //                     orderby wortGruppe.Count()
                         //                     select wortGruppe;

                         //foreach (var gruppe1 in längeUndAnfang)
                         //{
                         //    Console.WriteLine("Anfangsbuchstabe '{0}':", gruppe1.Key);
                         //    foreach (var gruppe2 in gruppe1)
                         //    {
                         //        Console.WriteLine("Wortlänge '{0}'", gruppe2.Length);
                         //        foreach(var wort in gruppe2)
                         //        {
                         //            Console.Write("{0}", wort);
                         //        }
                         //        Console.WriteLine();
                         //    }
                         //}
                         //Console.WriteLine();

}


//Aufgabe 2
static void Aufgabe2()
{
    Console.WriteLine("Geben Sie die Prozesse auf Ihrem System gruppiert nach der Anzahl der Threads aus");
    Console.WriteLine();

    var processes = Process.GetProcesses();

    var threadcounter = processes.OrderBy(p => p.Threads.Count).GroupBy(p => p.Threads.Count, p => p, (counter, thread) => 
                        new
                        {
                            Threadcounter = counter,
                            Threadname = thread
                        });

    foreach (var thread in threadcounter)
    {
        Console.WriteLine("Anzahl der Threads: {0}", thread.Threadcounter);
        foreach(var proc in thread.Threadname)
        {
            Console.WriteLine("{0}", proc);
        }
    }
    Console.WriteLine();
    

    Console.WriteLine("Geben Sie die Prozesse auf Ihrem System gruppiert nach der Anzahl der Module aus");
    Console.WriteLine();

    try
    {
        var moduleCount = processes.OrderBy(p => p.Modules.Count).GroupBy(p => p.Modules.Count, p => p, (counter, module) =>
                    new
                    {
                        ModuleCounter = counter,
                        ModuleName = module
                    });

        foreach (var module in moduleCount)
        {
            Console.WriteLine("Anzahl der Module: {0}", module.ModuleCounter);
            foreach (var proc in module.ModuleName)
            {
                Console.WriteLine("{0}", proc);
            }
        }
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    Console.WriteLine();

    Console.WriteLine("Geben Sie die Prozesse auf Ihrem System gruppiert nach der Anzahl der Module aus, in der Ausgabe sollen die Namen der Prozesse alphabetisch aufsteigend sortiert sein");
    Console.WriteLine();

    try
    {
        var moduleCountNachName = processes.OrderBy(p => p.ProcessName).GroupBy(p => p.Modules.Count, p => p, (counter, module) =>
                new
                {
                    ModuleCounter = counter,
                    ModuleName = module
                });

        foreach (var module in moduleCountNachName)
        {
            Console.WriteLine("Anzahl der Module: {0}", module.ModuleCounter);
            foreach (var proc in module.ModuleName)
            {
                Console.WriteLine("{0}", proc);
            }
        }
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    Console.WriteLine();
}

//Aufgabe 3
static void Aufgabe3()
{
    int[] factorsOf300 = { 2, 2, 3, 5, 5 };
    int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
    int[] numbersB = { 1, 3, 5, 7, 8 };


    Console.WriteLine("1. Welche einzelnen Faktoren sind in factorsOf300 vertreten?");
    Console.WriteLine();

    var factorDistinct = factorsOf300.Distinct();

    foreach(var factor in factorDistinct)
    {
        Console.WriteLine(factor.ToString());
    }
    Console.WriteLine();

    Console.WriteLine("2. Wie ist die Vereinigungsmenge der beiden Arrays numbersA und numbersB?");
    Console.WriteLine();

    var factorUnion = numbersA.Union(numbersB);

    foreach(var factor in factorUnion)
    {
        Console.WriteLine(factor);
    }
    Console.WriteLine();

    Console.WriteLine("3. Haben die beiden Arrays numbersA und numbersB eine Schnittmenge?");
    Console.WriteLine();

    var factorInter = numbersA.Intersect(numbersB);

    foreach (var factor in factorInter)
    {
        Console.WriteLine(factor);
    }
    Console.WriteLine();

    Console.WriteLine("4. Welche Elemente kommen nur in numbersB vor, aber nicht in numbersA?");
    Console.WriteLine();

    var factorExcept = numbersB.Except(numbersA);

    foreach (var factor in factorExcept)
    {
        Console.WriteLine(factor);
    }
    Console.WriteLine();
}