// написать алгоритм, который
// на вход получает три числа
// на выход выдает максимальное из них.

Console.Write("Введите число 1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int max = numberA;
Console.Write("Введите число 2: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberB > numberA)
{
    max = numberB;
    if (numberC > max)
    {
        max = numberC;
    }
}
if (numberC > max)
{
    max = numberC;
    if (numberA > max)
    {
        max = numberA;
    }
}

Console.WriteLine($"Наибольшее - {max}");
