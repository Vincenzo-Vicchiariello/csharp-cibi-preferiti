// See https://aka.ms/new-console-template for more information
/*
 * Console.WriteLine("Ecco la classifica dei miei cibi preferiti!");
string[] favFoods = { "Tiramisù", "Pizza", "Cioccolata alla menta", "Uva rossa", "Parmigiana di melanzane" };
int foodsListLength = favFoods.Length;

Console.WriteLine(foodsListLength);

for (int i = 0; i < foodsListLength; i++)
{
    Console.WriteLine($"-{i + 1}.   {favFoods[i]}");
}

Console.WriteLine($"Il mio cibo top è {favFoods[0]}");

Console.WriteLine($"Il mio cibo preferito ma non troppo è {favFoods[foodsListLength - 1]}");

Funziona anche senza le funzioni, non riesco a capire come dovrei integrarle.
*/
using System.Drawing;

Console.WriteLine("Quanti cibi preferiti hai?");
int favFoodsAmount = int.Parse(Console.ReadLine());


Console.WriteLine(favFoodsAmount);

string[] foodList = new string[favFoodsAmount];

for (int i = 0; i < foodList.Length; i++)
{
    Console.WriteLine("Dimmi un cibo");
    string food = Console.ReadLine();
    foodList[i] = food;
}

for (int i = 0; i < foodList.Length; i++)
{
    Console.WriteLine($"-{i + 1}.  {foodList[i]}"); 
}

