// Программа, которая принимает целые числа, до тех пор пока не будет введено число 0, и выводит значение второго максимума из этих чисел.


int[] array;
int e = 100;
array = new int[e];
int imax = 0;
int imax2 = 0;
System.Console.WriteLine("Введите числа: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    while (array[i] != 0)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (imax < array[i])
        {
            imax2 = imax;
            imax = array[i];
        }
        else if (imax2<array[i])
        {
            imax2 = array[i];
        }    
    }
    break;
}
System.Console.WriteLine($"Второе по максимуму - число {imax2}");
