namespace RecordsVoorbeeld;

// Een record met een primary constructor. In een regel krijg je:
// init-only properties X en Y, waarde-gelijkheid, een leesbare ToString
// en een Deconstruct. Handig voor data die je vooral wil doorgeven.
public record Punt(int X, int Y);

public record Persoon(string Naam, int Leeftijd);
