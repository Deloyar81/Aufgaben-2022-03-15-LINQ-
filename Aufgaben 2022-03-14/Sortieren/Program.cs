Aufgabe1();
Aufgabe2();
Aufgabe3();

Console.ReadLine();


//Aufgabe1()
static void Aufgabe1()
{
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

    Console.WriteLine("1.Geben Sie das obige Array aufsteigend sortiert aus");
    Console.WriteLine();

    var order = numbers.OrderBy(x => x);

    foreach(var number in order)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Console.WriteLine("2.Geben Sie das obige Array absteigend sortiert aus");
    Console.WriteLine();

    var orderdesc = numbers.OrderByDescending(x => x);

    foreach (var number in orderdesc)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Console.WriteLine("3.Geben Sie aus dem obigen Array alle graden Zahlen aufsteigend sortiert aus");
    Console.WriteLine();

    var orderAufGerade = numbers.Where(x => x % 2 == 0).OrderBy(x => x);

    foreach (var number in orderAufGerade)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();
}

//Aufgabe 2
static void Aufgabe2()
{
    string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen" };


    Console.WriteLine("1. Geben Sie das obige Array nach der Länge der Worte aufsteigend sortiert aus");
    Console.WriteLine();

    var orderString = numbers.OrderBy(x => x.Length);

    foreach (var number in orderString)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Console.WriteLine("2. Geben Sie das obige Array nach der Länge der Worte aufsteigend sortiert aus, bei gleicher Länge soll alphabetisch absteigend sortiert werden");
    Console.WriteLine();

    var orderString2 = numbers.OrderBy(x => x.Length).ThenByDescending(x => x);

    foreach (var number in orderString2)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Console.WriteLine("3. Drehen Sie die Reihenfolge der Elemente im Array um");
    Console.WriteLine();

    var orderString3 = numbers.Reverse();

    foreach (var number in orderString3)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\Steam");

    FileInfo[] fileInfo = directoryInfo.GetFiles();

    Console.WriteLine("4. Listen Sie alle Dateien in dem Verzeichnis {0}, absteigend nach Namen sortiert auf", directoryInfo);
    Console.WriteLine();

    var orderDirectory = fileInfo.OrderByDescending(x => x.Name);

    foreach (FileInfo number in orderDirectory)
    {
        Console.WriteLine(number.Name);
    }
    Console.WriteLine();

    Console.WriteLine("5. Listen Sie alle Dateien in dem Verzeichnis, nach Größe aufsteigend sortiert auf");
    Console.WriteLine();

    var orderDirectory2 = fileInfo.OrderBy(x => x.Length);

    foreach (FileInfo number in orderDirectory2)
    {
        Console.WriteLine("Dateiname: {0} \nGröße in KB: {1}", number.Name, number.Length / 1000);
    }
    Console.WriteLine();

    Console.WriteLine("6. Listen Sie alle Dateien in dem Verzeichnis, nach dem Datum des letzten Zugriffs auf, jüngste Dateien zuerst");
    Console.WriteLine();

    var orderDirectory3 = fileInfo.OrderByDescending(x => x.LastAccessTime);

    Console.WriteLine(string.Join("\n", orderDirectory3));

    foreach (FileInfo number in orderDirectory3)
    {
        Console.WriteLine("Dateiname: {0} \nLetzter Zugriff: {1}", number.Name, number.LastAccessTime);
    }
    Console.WriteLine();
}

//Aufgabe 3
static void Aufgabe3()
{
    int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 22, 12, 16, 18, 11, 19, 13 };

    Console.WriteLine("1. Ermitteln Sie die ersten 5 Elemente im Array");
    Console.WriteLine();

    var numbers5 = numbers.Take(5);

    foreach (var number in numbers5)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Console.WriteLine("2. Ermitteln Sie die letzten 5 Elemente im Array");
    Console.WriteLine();

    var numbers2 = numbers.Skip(numbers.Length - 5);

    foreach (var number in numbers2)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Console.WriteLine("3. Ermitteln Sie alle Elemente, bis auf die ersten und letzten drei Elemente ");
    Console.WriteLine();

    var numberAllExcept = numbers.Skip(3).SkipLast(3);

    foreach (var number in numberAllExcept)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();


    Console.WriteLine("4. Ermitteln Sie alle Elemente, beginnend vom ersten Element, die größer als 0 sind");
    Console.WriteLine();

    var numbersAllgreater0 = numbers.Where(x => x > 0);

    foreach (var number in numbersAllgreater0)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    Console.WriteLine("5. Ermitteln Sie alle Elemente, beginnend vom ersten Element, die nach der 12 im Array stehen");
    Console.WriteLine();

    var numbersAfter12 = numbers.SkipWhile(x => x != 12).Skip(1);

    foreach (var number in numbersAfter12)
    {
        Console.WriteLine(number);
    }
    Console.WriteLine();

    DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\Steam");

    FileInfo[] fileInfo = directoryInfo.GetFiles();


    Console.WriteLine("7. Listen Sie die fünf neuesten Dateien in dem Verzeichnis auf");
    Console.WriteLine();

    var fileCreationTime = fileInfo.OrderByDescending(x => x.CreationTime).Take(5);

    foreach (var number in fileCreationTime)
    {
        Console.WriteLine("Dateiname: {0} \nErstellungsdatum: {1}", number.Name, number.CreationTime);
    }
    Console.WriteLine();

    Console.WriteLine("8. Listen Sie alle Dateien in dem Verzeichnis in „Seiten“ zu je 5 Dateien auf");
    Console.WriteLine();

    var filelist = fileInfo;
    int index = 0;

    for(int i = 0; i < filelist.Count(); i += 5)
    {
        var output = filelist.Take(i + 5).Skip(i);

        Console.WriteLine();

        foreach(var number in output)
        {
            Console.WriteLine(number);
        }
        
    }
    Console.WriteLine();
}