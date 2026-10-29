Console.WriteLine("Podaj ilość tur.");
int tury = int.Parse(Console.ReadLine());
int tury1 = 1;
int suma = 0;
List<int> zlotoNaTure = new List<int>
{
};
for (int i = 0; i < tury; i++)
{
    bool petla = true;
    while (petla)
    {
        Console.WriteLine("Ile złota zdobyto w " + tury1 + " turze?");
        int zloto  = int.Parse(Console.ReadLine());
        if (zloto >= 0)
        {
            zlotoNaTure.Add(zloto);
            petla = false;
            tury1++;
            suma += zloto;
        }
        else
        {
            Console.WriteLine("Podaj wartość nieujemną.");
        }
    }
}
int max = zlotoNaTure[0];
int min = zlotoNaTure[0];
int najlepszy = zlotoNaTure[0];
int pierwszyNajlepszy = 1;
int liczbaTurZMax = 0;
int pierwszaTuraBezZlota = 0;
bool czyPierwsza = false;
Console.WriteLine("Suma: " + suma);
for (int i = 0; i < zlotoNaTure.Count; i++)
{
    if (min > zlotoNaTure[i])
    {
        min = zlotoNaTure[i];
    }

    if (max < zlotoNaTure[i])
    {
        max = zlotoNaTure[i];
    }

    if (najlepszy < zlotoNaTure[i])
    {
        pierwszyNajlepszy = i+1;
        najlepszy =  zlotoNaTure[i];
    }

    if (zlotoNaTure[i] == 0 && czyPierwsza == false)
    {
        pierwszaTuraBezZlota = i+1;
        czyPierwsza = true;
    }
}
Console.WriteLine("Minimum: " + min);
Console.WriteLine("Maximum: " + max);
Console.WriteLine("Pierwszy najlepszy wynik: tura "  + pierwszyNajlepszy);
for (int i = 0; i < zlotoNaTure.Count; i++)
{
    if (zlotoNaTure[i] == max)
    {
        liczbaTurZMax++;
    }
}
Console.WriteLine("Liczba tur z maksimum: " +  liczbaTurZMax);
if (pierwszaTuraBezZlota == 0)
{
    Console.WriteLine("Nie było tury bez złota.");
}
else
{
    Console.WriteLine("Pierwsza tura bez złota:  " + pierwszaTuraBezZlota);
}
