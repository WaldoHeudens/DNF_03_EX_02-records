using RecordsVoorbeeld;

var a = new Punt(1, 2);
var b = new Punt(1, 2);

// Waarde-gelijkheid: twee records met dezelfde inhoud zijn gelijk,
// ook al zijn het twee aparte objecten.
Console.WriteLine(a == b);      // True
Console.WriteLine(a.Equals(b)); // True

// De gegenereerde ToString toont de inhoud.
Console.WriteLine(a);           // Punt { X = 1, Y = 2 }

// with-expressie: maak een kopie met enkele gewijzigde waarden.
// Het origineel blijft ongewijzigd.
var verschoven = a with { X = 10 };
Console.WriteLine(verschoven);  // Punt { X = 10, Y = 2 }
Console.WriteLine(a);           // Punt { X = 1, Y = 2 }

var luna = new Persoon("Luna", 20);
var ouder = luna with { Leeftijd = 21 };
Console.WriteLine(ouder);       // Persoon { Naam = Luna, Leeftijd = 21 }
