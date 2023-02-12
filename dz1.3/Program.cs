// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 22 3 9 -> 22
Console.WriteLine("Даны 3 числа (22, 3, 9)");

int numberA = 22;
int numberB = 3;
int numberC = 9;

int max = numberA;
int min = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("Максимально число: ");
Console.WriteLine(max);