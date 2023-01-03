Console.Clear();

int[,] Create2dArray()
{
    Console.Write("Введите кол-во строк: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во столбцов: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[row, colums];

    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
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



/*
int[,] SortedArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {       
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {       
            int maxP = j;    
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,k] > array[i, maxP])
                {
                    maxP = k;
                }
            }          
            int temp = array[i, j];
            array[i, j] = array[i, maxP];
            array[i, maxP] = temp;
        }
    }
    return array;
}



int[,] myArray = Create2dArray();
ShowArray(myArray);
Console.WriteLine();
int[,] sortArray = SortedArray(myArray);
ShowArray(sortArray);
*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[] FindMinSumElementsRow(int[,] array)
{
    int[] array1d = new int[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        array1d[i] = sum;
    }
    return array1d;
}
int FindIndex(int[] array)
{
    int minI = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < array[minI])
        {
            minI = i;
        }
    }
    return minI;
}

int[,] my2dArray = Create2dArray();
ShowArray(my2dArray);
int[] my1dArray = FindMinSumElementsRow(my2dArray);
int result = FindIndex(my1dArray);
Console.Write($"Строка с наименьшей суммой элементов: {result + 1}");
*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4       2*3 + 4*3     2*4 + 4*3      18 20
// 3 2 | 3 3       3*3 + 2*3     3*4 + 2*3      15 18
// Результирующая матрица будет:
// 18 20
// 15 18

// a1 b1       c1 d1       a1c1 + b1c2    a1d1 + b1d2
//         *           =   
// a2 b2       c2 d2       a2c1 + b2c2    a2d1 + b2d2

/*
int[,] CreatMatrix()
{
    int[,] array = new int[2, 2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(2, 5);
        }
    }
    return array;
}

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{

    int[,] finalArray = new int[array1.GetLength(1), array2.GetLength(0)];
    // for (int i = 0, k = 0; i < array1.GetLength(0); i++, k++)
    // {
    //     int sum = 0;
    //     for (int j = 0, l = 0; j < array2.GetLength(1); j++, l++)
    //     {
    //         sum = array1[i, j] * array2[i, j] + array1[i, j + 1] * array2[i + 1, j];
    //         finalArray[k, l] = sum;
    //     }

    // }
    finalArray[0,0] = array1[0,0] * array2[0,0] + array1[0,1] * array2[1,0];

    finalArray[0,1] = array1[0,0] * array2[0,1] + array1[0,1] * array2[1,1];

    finalArray[1,0] = array1[1,0] * array2[0,0] + array1[1,1] * array2[1,0];

    finalArray[1,1] = array1[1,0] * array2[0,1] + array1[1,1] * array2[1,1];

    return finalArray;
}

int[,] matrix1 = CreatMatrix();
int[,] matrix2 = CreatMatrix();
ShowArray(matrix1);
Console.WriteLine();
ShowArray(matrix2);
Console.WriteLine();
int[,] resultArray = MatrixMultiplication(matrix1, matrix2);
ShowArray(resultArray);
*/

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Можно сделать запрос на ввод значений пользователем, но тогда написать проверку не повторяет ли пользователь числа.
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)

// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//выодить как в примере, или послойно

// int[,,] Create3dArray()
// {
//     int paig = 2;
//     int rows = 2;
//     int colums = 2;
//     int[,,] array3d = new int[paig, rows, colums];
//     int[] testArray = new int[paig * rows * colums];
//     Console.WriteLine("Заполните массив значениями: ");
//     // for(int h = 0; h < testArray.Length; h++) 
//     // {
//     //     Console.Write($"Введите {h + 1}й эллемент: ");
//     //     int num = Convert.ToInt32(Console.ReadLine());
//     //     if(num > 9 && num < 100)
//     //     {
//     //     testArray[h] = num;
//     //     }
//     // }         

//     for (int i = 0; i < array3d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3d.GetLength(2); k++)
//             {
//                 int num = new Random().Next(10,100);
//                 array3d[i,j,k] = num;
//             }
//         }
//     }
//     return array3d;
// }

// void Show3dArray(int[,,] array3d)
// {
//     for (int i = 0; i < array3d.GetLength(0); i++)
//     {
//         Console.WriteLine($"Лист № {i + 1}");
//         for (int j = 0; j < array3d.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3d.GetLength(2); k++)
//             {
//                 Console.Write($"{array3d[i, j, k]}({j}, {k})   ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
// int[,,] my3dArray = Create3dArray();
// Show3dArray(my3dArray);

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. или любых размеров 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void ShowNewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + " ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] CreateSortedArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];   
    int curent = 1;    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = array[i,j] + curent;
            curent++;
        }

    }
    return array;
}


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateSortedArray(rows, colums);
ShowNewArray(myArray);













































// int[] arr()
// {
//     int paig = 2;
//     int rows = 2;
//     int colums = 2;
//     int[,,] array3d = new int[paig, rows, colums];
//     int[] testArray = new int[paig * rows * colums];
//     int arraySize = 0;
//     Console.WriteLine("Заполните массив значениями: ");
//     for (int h = 0; h < testArray.Length; h++)
//     {
//         Console.Write($"Введите {h + 1}й эллемент: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num > 9 && num < 100)
//         {

//             for (int g = 0; g < arraySize; g++)
//             {
//                 if (num != testArray[g])
//                 {
//                     testArray[h] = num;
//                 }
//                 arraySize = arraySize + 1;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Число не двузначное, начните заново");
//             break;
//         }
//     }
//     return testArray;
// }
// void Show(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine();
// }
// int[] arret = arr();
// Show(arret);

// //заполняем массив значениями, а потом проверяем, нет ли в нем повторений?


// num = Console.ReadLine()
// if(num != array[i])




