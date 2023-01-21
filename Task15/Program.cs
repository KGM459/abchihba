// на вход принимает число
// на выход говорит является ли день недели под этим числом выходным
Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if ( day > 7 )
{
    Console.WriteLine("Введенно неправильное число");
}
if ( day < 1 )
{
    Console.WriteLine("Введенно неправильное число");
}
if ( day <= 5)
{
    Console.WriteLine("Нет");
}
if ( day > 5)
{
    Console.WriteLine("Да");
}


