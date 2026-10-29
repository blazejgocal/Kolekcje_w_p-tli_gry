using System.ComponentModel;

List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Pochodnia"
};
Console.WriteLine("Ilość rzeczy w plecaku: " + plecak.Count);
int licznik = 0;
foreach (string rzecz in plecak)
{
    licznik++;
    Console.WriteLine(licznik + " " + rzecz);
}
Console.WriteLine("Co znaleziono na wyprawie?.");
string item = Console.ReadLine()!;
plecak.Add(item);
Console.WriteLine("Dodano " + item + " do plecaka");
Console.WriteLine("Użyto mikstury");
plecak.Remove("Mikstura");
licznik = 0;
foreach (string rzecz in plecak)
{
    licznik++;
    Console.WriteLine(licznik + " " + rzecz);
}

