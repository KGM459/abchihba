// написать программу, которая:
// 1. На вход принимает число
// 2. На выход отвечает, четное ли это число или нет


Console.Write("введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine($"Да");
}
else 
{
    Console.WriteLine($"Нет");
}