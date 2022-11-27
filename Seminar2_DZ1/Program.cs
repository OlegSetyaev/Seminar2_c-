//Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = (n / 10) % 10;
System.Console.WriteLine(n1);

