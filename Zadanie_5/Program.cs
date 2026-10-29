List<string> przedmioty = new List<string>
{
    "Miecz",
    "Tarcza",
    "Mikstura",
    "Klucz"
};
int licznik = 0;
for (int i = 0; i < przedmioty.Count; i++)
{
    Console.WriteLine(i+1 + ". " + przedmioty[i]);
    licznik++;
}

bool petla = true;
int item = 0;
Console.WriteLine("Podaj numer przedmiotu który usunąć.");
while (petla)
{
    string item1 = Console.ReadLine();
    if (int.TryParse(item1, out item))
    {
        if (item >= 1 && item <= licznik)
        {
            przedmioty.RemoveAt(item);
            Console.WriteLine("Usunięto przedmiot " + przedmioty[item]);
        }
        else
        {
            Console.WriteLine("Numer musi należeć do zakresu 1-" +  licznik);
        }
    }
    else
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
    }
}