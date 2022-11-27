// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1)
{
    System.Console.WriteLine("Нет такого дня =)");
}
else
{
    if (number == 6 || number == 7)
    {
        System.Console.WriteLine($"{number} ДА!");
    }
    else
    {
        System.Console.WriteLine($"{number} НЕТ!");
    }
}