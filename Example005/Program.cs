Console.Clear();
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine($"array [{i + 1}] is {array[i]}");;
    Console.WriteLine();
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CurrentArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999 + 1);
    }
    return array;
}

int EvenNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}
/*
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CurrentArray(size);
ShowArray(myArray);

int result = EvenNum(myArray);
Console.Write("Количество четных чисел в массиве = " + result);
*/

//----------------------------------------------------------------------------------------------------------------------------------------

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] AnotherArray(int size)
{
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(-100, 100 + 1);
    }
    return myArray;
}

void ShowForThisArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine($"array [{i}] = {array[i]}");;
    Console.WriteLine();
}

int SumOfElements(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
       sum = sum + array[i];
    }
    return sum;
}

/*
Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = AnotherArray(size);
ShowForThisArray(myArray);
int result = SumOfElements(myArray);
Console.Write($"Cумма элементов, стоящих на нечётных позициях = {result}");
*/

//----------------------------------------------------------------------------------------------------------------------------------------

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] DoubleArray (int size, int min, int max)
{
    double[] anoterArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        anoterArray[i] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), 2);
    }
    return anoterArray;
}
void ShowDoubleArray (double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine($"array [{i}] is {array[i]}");;
    Console.WriteLine();
}

double SearchDifference(double[] array)
{
    double myMin = array[0];
    double myMax = array[0];   
    double result = 0; 
    
    for(int i = 0; i < array.Length; i++)
    {            
        if(array[i] < myMin)
        {
            myMin = array[i];
        }
        if(array[i] > myMax)
        {
            myMax = array[i];
        }        
    }  
    result = myMax - myMin;
    return result;                     
}            


Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = DoubleArray(size, min, max);
ShowDoubleArray(myArray);

// SearchDifference(myArray);
// ShowDoubleArray(myArray);

double result = SearchDifference(myArray);
Console.Write($"Разница между максимальным и минимальным элементов массива = {result}");

