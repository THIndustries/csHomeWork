// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Clear();
// int MathPow(int arg1, int arg2)
// {
//     int step = arg1;    
//     for(int i = 1; i < arg2; i++)
//     {        
//         step = step * arg1;        
//     }
//     return step;
// }

// Console.Write("Введите число А: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите чиcло В: ");
// int numB = Convert.ToInt32(Console.ReadLine());

// int result = MathPow(numA, numB);
// Console.Write(result);

//---------------------------------------------------------------------------------------------------------------------------------------------

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int SumOfNumbers(int arg)
{
    
    int sum = 0;
    int current = 0;
      
        while(arg > 0)
    {        
        current = arg % 10;
        sum = sum + current;        
    }
    return sum; 
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfNumbers(number);
Console.Write(result);

//---------------------------------------------------------------------------------------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int[] CreateRandomArray (int size, int min, int max)
// {
//     int[] array = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"array [{i + 1}] is {array[i]}");
//     }
// }
// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);