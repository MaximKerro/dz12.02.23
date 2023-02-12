// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Дано число: 8(N), какие четные числа стоят от 1 до N?");

int number = 8;
int i = 1;
bool not = true;



while (i <= number)
{
    if (i % 2 != 1)
    {  
        
        Console.WriteLine("Число " + i + " является: ЧЁТНЫМ");
        
        not = false;
    }

i++;   
}

if (not)
{
    Console.WriteLine("Нет четных чисел!");
}
