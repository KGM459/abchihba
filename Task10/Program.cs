// Написать программу, которая:
// на вход принимает трехзначное число
// на выходе показывает вторую цифру  этого числа

Console.WriteLine ("Введите число от 100 до 999");
int num = Convert.ToInt32(Console.ReadLine());
if ( num > 999)
{
    Console.WriteLine ("Введенно неправильное число");
}
if ( num < 100)
{
    Console.WriteLine ("Введенно неправильное число");
}
int SecondDigit = num % 100 / 10 ;
Console.WriteLine ($"{SecondDigit}");
