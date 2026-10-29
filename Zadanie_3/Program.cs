Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};
Console.WriteLine("Ilość pozycji: " + ceny.Count);
foreach (KeyValuePair<string, int> item in ceny)
{
    Console.WriteLine("Rzecz: " + item.Key + " | " + "Cena: " + item.Value);
}
Console.WriteLine("Podaj przedmiot.");
string przedmiot = Console.ReadLine()!;
if (ceny.ContainsKey(przedmiot))
{
    Console.WriteLine("Cena: " + ceny[przedmiot]);
}
else
{
    Console.WriteLine("Brak takiego przedmiotu.");
}
ceny["Mikstura"] = 12;
foreach (KeyValuePair<string, int> item in ceny)
{
    Console.WriteLine("Rzecz: " + item.Key + " " + "Cena: " + item.Value);
}