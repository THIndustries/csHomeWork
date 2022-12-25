Console.Clear();
//  Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] Create2dArray(int arg1, int arg2)
{
    // Console.Write("Введите минимальное значение: ");
    // int minValue = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Введите максимальное значение: ");
    // int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[arg1, arg2];

    for (int i = 0; i < newArray.GetLength(0); i++)    
        for (int j = 0; j < newArray.GetLength(1); j++)        
            newArray[i, j] = new Random().Next(1, 10); 
    return newArray;
}
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"[{array[i, j]}]");
        }
        Console.WriteLine();
    }
}
int[,] SortedArray(int[,] array)
{
    
    for(int i=0; i< array.GetLength(0) - 1; i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int maxPosition = array[i,j];
            if(maxPosition < array[i,j])
            {
                maxPosition = array[i,j];
            }
            int temporary = array[i,j];
            array[i,j] = array[i,maxPosition];
            array[i,maxPosition] = temporary;
        }
    }
    return array;
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(row, colums);
ShowArray(myArray);
int[,] sortArray = SortedArray(myArray);
ShowArray(sortArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07