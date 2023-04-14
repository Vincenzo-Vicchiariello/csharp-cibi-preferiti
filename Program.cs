// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ecco la classifica dei miei cibi preferiti!");
string[] favFoods = { "Tiramisù", "Pizza", "Cioccolata alla menta", "Uva rossa", "Parmigiana di melanzane" };
int foodsListLength = favFoods.Length;

Console.WriteLine(foodsListLength);

for (int i = 0; i < foodsListLength; i++)
{
    Console.WriteLine($"-{i + 1}.   {favFoods[i]}");
}

Console.WriteLine($"Il mio cibo top è {favFoods[0]}");

Console.WriteLine($"Il mio cibo preferito ma non troppo è {favFoods[foodsListLength - 1]}");

