Console.Clear();
//  Урок 7. Двумерные массивы

//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] Create2dArray()
{
    Console.WriteLine("Введите кол-во строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 1);
        }
    }
    return array;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
}
double[,] myArray = Create2dArray();
Show2dArray(myArray);
*/

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

int[,] Create2dArray2()
{
    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t[{array[i, j]}] ");
        }
        Console.WriteLine();
    }
}
// void-вариант:
// void FindElement(int[,] array)
// {
//     Console.Write("Введите номер строки: ");
//     int numRows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите номер стоблика: ");
//     int numColums = Convert.ToInt32(Console.ReadLine());

//     if (numRows > array.GetLength(0) || numColums > array.GetLength(1))
//     {
//         Console.Write("Числа с такими индексами в массиве нет");
//     }
//     else
//     {
//         Console.Write($"Число по вашему адресу = {array[numRows, numColums]}");
//     }

// }
// Console.WriteLine("Создадим массив: ");
// int[,] myArray = Create2dArray2();
// Show2dArray(myArray);
// Console.WriteLine("Поищем интересующее вас значение (отсчет начинается с нуля): ");
// FindElement(myArray);

//возвращающий вариант:
int FindNum(int[,] array)
{
    Console.Write("Введите номер строки: ");
    int numRows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер стоблика: ");
    int numColums = Convert.ToInt32(Console.ReadLine());
    if (numRows > array.GetLength(0) || numColums > array.GetLength(1))
    {
        return 01;
    }
    else
    {
        return array[numRows, numColums];
    }


}
/*
Console.WriteLine("Создадим массив: ");
int[,] myArray = Create2dArray2();
Show2dArray(myArray);
Console.WriteLine("Поищем интересующее вас значение (отсчет начинается с нуля): ");
int result = FindNum(myArray);
if(result == 01)
    Console.Write("Числа с такими индексами в массиве нет");
else 
    Console.Write($"Число по вашему адресу = {result}");
*/

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateNewArray(int arg1, int arg2) // функция, генерирующая массив
{
    int[,] array = new int[arg1, arg2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void ShowNewArray(int[,] array) // функция, которая будет выводить массив в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"\t[{array[i, j]}]");
        }
        Console.WriteLine();
    }
}

double[] FindAverageNum(int[,] array) // функция, которая будет находить среднее арифметическое элементов и выводить результат как одномерный массив.
{
    double[] newArray = new double[array.GetLength(1)];
    double sum = 0;
    double averege = 0;
    
        // for (int j = 0; j < array.GetLength(1); j++)
        // {
        //     for (int i = 0; i < array.GetLength(0); i++)
        //     {
        //         sum = sum + array[i, j];                              
        //     }
        //     averege = Math.Round(sum / array.GetLength(0), 1);
        //     newArray[j] = averege;
        // }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i, j];                              
            }
            averege = Math.Round(sum / array.GetLength(0), 1);
            newArray[j] = averege;
        }
    

    return newArray;
}
void ShowDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\t[{array[i]}]");
    }
    Console.WriteLine();
}
Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateNewArray(rows, colums);
ShowNewArray(myArray);
double[] resultArray = FindAverageNum(myArray);
Console.WriteLine("\nCреднее арифметическое элементов в каждом столбце: ");
ShowDoubleArray(resultArray);