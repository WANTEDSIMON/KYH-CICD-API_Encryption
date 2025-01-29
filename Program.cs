var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World-2!");

// Endpoint som tar emot två bokstäver som query-parametrar
app.MapGet("/letters", (string L1, string L2) =>
{
    int num1 = GetLetterPosition(L1);
    int num2 = GetLetterPosition(L2);
    int sum = num1 + num2;
    
    return $"Bokstäver: {L1} ({num1}), {L2} ({num2}) → Summan: {sum}";
});

// Endpoint för att ta en numerisk summa och returnera alla möjliga bokstavskombinationer
app.MapGet("/collections", (int sum) =>
{
    var letterPairs = GetLetterPairs(sum);
    return letterPairs.Count > 0 
        ? $"Möjliga bokstavskombinationer för {sum}: {string.Join(", ", letterPairs)}"
        : $"Ingen giltig kombination hittades för {sum}.";
});

app.Run();

// Metod för att beräkna en bokstavs position i alfabetet
int GetLetterPosition(string letter)
{
    if (!string.IsNullOrEmpty(letter) && char.IsLetter(letter[0]))
    {
        return char.ToUpper(letter[0]) - 'A' + 1;
    }
    return 0; // Returnera 0 om input är ogiltig
}

// Metod för att hitta alla möjliga bokstavspar som ger den angivna summan
List<string> GetLetterPairs(int sum)
{
    List<string> pairs = new List<string>();

    for (char first = 'A'; first <= 'Z'; first++)
    {
        for (char second = 'A'; second <= 'Z'; second++)
        {
            if ((first - 'A' + 1) + (second - 'A' + 1) == sum)
            {
                pairs.Add($"{first}{second}");
            }
        }
    }

    return pairs;
}
