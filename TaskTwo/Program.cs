// написать программу которая:
// 1. на входе берет два числа
// 2. на выходе показывает большее число 
 Console.Write("Введите число 1: ");

int numberA = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите число 2: ");

int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} > {numberB}");
}
else 
{
    Console.WriteLine($"Число {numberB} > {numberA}");
}
