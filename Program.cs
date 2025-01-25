var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Dogs!");

app.MapGet("/doggycare/add", (int num1, int num2) => dogAdd(num1, num2));
// /doggycare?num1=5&num2=8

app.MapGet("/doggycare/Subtract", (int num1, int num2) => dogSubtract(num1, num2));
// /doggycare/dogs?num1=5&num2=8

app.MapGet("/doggycare/dogs", (int num1, int num2) => Extra (num1, num2));
// /doggycare/dogs?num1=5&num2=8

app.Run();

string dogAdd(int num1, int num2)
{
    return $"Summan av {num1} och {num2} är: {num1 + num2}";
}

string dogSubtract(int num1, int num2)
{
    return $"Differensen av {num1} och {num2} är: {num1 - num2}";
}

string Extra(int num1, int num2)
{
    return $"Differensen av {num1} och {num2} är: {num1 - num2}";
}