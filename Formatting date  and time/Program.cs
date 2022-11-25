using System.Globalization;

DateTime Aprilfools = new DateTime(2025,4,1,13,23,30);

// //'d' is used for short date
// Console.WriteLine($"{Aprilfools:d}");

// //'D' used for full date
// Console.WriteLine($"{Aprilfools:D}");

// //'f' is used for short time and full date
// Console.WriteLine($"{Aprilfools:f}");

// //'F' is used for full time and full date
// Console.WriteLine($"{Aprilfools:F}");

// //'g' Genral date and time
// Console.WriteLine($"{Aprilfools:g}");

// //'G' Genral date and time
// Console.WriteLine($"{Aprilfools:G}");

//Format Using a specific CultureInfo

Console.Write(Aprilfools.ToString("d",CultureInfo.CreateSpecificCulture("de-DE")));

//Defining custom Date and time
Console.WriteLine($"{Aprilfools: dddd,MMMM,d yyyy}");
Console.WriteLine($"{Aprilfools: ddd h:mm:ss tt}");
Console.WriteLine($"{Aprilfools: MMM d yyy}");


