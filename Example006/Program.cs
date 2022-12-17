Console.Clear();

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("\nВывод массива: ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i}] = {array[i]}");
    }
    Console.WriteLine();
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Без массива:
int PositiveNum()
{
    int count = 0;
    int i = 0;
    int num = 0;
    Console.Write("Введите кол-во чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    while(i < size)
    {
        Console.Write($"Введите {i + 1}е число: ");
        num = Convert.ToInt32(Console.ReadLine());
        i++;
            if(num > 0)
                count++;
    }
 
    return count;
}
/*
int result = PositiveNum();
Console.WriteLine("Кол-во чисел больше 0, из введенных вами, равно " + result);
*/

//C массивом:
int[] CreateArrayFromUser()
{
    Console.Write("Введите кол-во чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}е число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int FindNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
    }
    return count;
}
/*
int[] myArray = CreateArrayFromUser();
// ShowArray(myArray);
int result = FindNum(myArray);
Console.WriteLine("Кол-во чисел больше 0, из введенных вами, равно " + result);
*/

//---------------------------------------------------------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1

void FindDot(double b1, double k1, double b2, double k2)
{   
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2; 

    if(k1 == k2 && b1 != b2)
    {
        Console.WriteLine($"Эти прямые паралельны и никогда не пересекутся.");       
    }   
    if(k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Это две прямые совпадают.");
    } 
    if(k1 != k2 && b1 != b2)
    {             
    Console.WriteLine($"Точка пересечения двух прямых находится по координате: x = {x}, y = {y}");
    }
}
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

FindDot(b1, k1, b2, k2);

