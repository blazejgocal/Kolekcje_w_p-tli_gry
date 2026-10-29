int[] zlotoWTurach = { 5, 12, 0, 8, 15};
double srednia = 0;
int turyCoNajmniejDycha = 0;
int lacznie = 0;
int licznik = 0;
foreach (int zloto in zlotoWTurach)
{
    licznik++;
    Console.WriteLine("Tura " + licznik +": " + zloto);
    srednia += zloto;
    if (zloto >= 10)
    {
        turyCoNajmniejDycha++;
    }
    lacznie += zloto;
}
Console.WriteLine("Zdobyto łącznie " + lacznie + " sztuk złota.");
Console.WriteLine("Średnia: " + srednia/5);
Console.WriteLine("Tury w których uzyskano conajmniej 10 sztuk złota: " + turyCoNajmniejDycha);
Console.Write("Od końca: ");
for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
{
    Console.Write(zlotoWTurach[i] + " ");
}