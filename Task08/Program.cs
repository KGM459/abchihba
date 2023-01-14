// Написать программу, которая:
// 1. На вход принимает число n
// 2. На выходе показывает все четные числа от 1 до N

Console.Write("введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{ 
    if (count % 2 == 0)
    {     
    Console.Write($"{count} ");
    }
    count++;
 }

