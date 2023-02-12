// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 44 5 78 -> 78
Console.WriteLine("Даны 3 числа (44, 5, 78)");

int numberA = 44;
int numberB = 5;
int numberC = 78;

int max = numberA;
int min = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("Максимально число: ");
Console.WriteLine(max);
