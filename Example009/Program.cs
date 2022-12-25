Console.Clear();
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNum (int arg)
{
    Console.Write(arg + " ");
    if (arg > 1)
    {
        ShowNum(arg -1);
    }
}
Console.Write("Введите ваше число: ");
int numN = Convert.ToInt32(Console.ReadLine());
ShowNum(numN);
*/



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumOfElements(int arg1, int arg2)
{
    if(arg1 == arg2)
    {
        return arg1;
    }
    return arg2 + SumOfElements(arg1, arg2 - 1);
}
Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int result = SumOfElements(numM, numN);
Console.Write($"Сумма натуральных элементов в промеждутке от {numM} до {numN} = {result}");
*/



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int NumOfAkkerman(int arg1, int arg2)
{
    if (arg1 == 0)
        return arg2 + 1;
    else
      if ((arg1 != 0) && (arg2 == 0))
        return NumOfAkkerman(arg1 - 1, 1);
    else
        return NumOfAkkerman(arg1 - 1, NumOfAkkerman(arg1, arg2 - 1));
}

Console.Write("Введите число m: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numN = Convert.ToInt32(Console.ReadLine());

int result = NumOfAkkerman(numM, numN);
Console.Write($"A({numM},{numN}) = {result}");
