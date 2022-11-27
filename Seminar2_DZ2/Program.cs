// Программа, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(number) < 99)
{
    System.Console.WriteLine("Нет 3-ей цифры!");
}
else
{
    while (Math.Abs(number) > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    System.Console.WriteLine($"{Math.Abs(number)}");
}