// написать программу, которая:
// 1. На вход принимает число
// 2. На выход отвечает, четное ли это число или нет

Console.Write("Хочешь узнать, является ли число четным или нет? введи его:  ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.WriteLine($"Число {numberA} - Четное!");
}
else 
{
    Console.WriteLine($"Число {numberA} - Не четное!");
}