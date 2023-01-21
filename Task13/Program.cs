// на вход: принимает число
//на выход: показывает третью цифру или говорит что ее нет.

Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
 Console.WriteLine("третьей цифры нет");
}
 while (num > 1000)
 {
    num = num / 10;
 }
 int ThirdDigit = num % 10;
Console.WriteLine($"{ThirdDigit}");
