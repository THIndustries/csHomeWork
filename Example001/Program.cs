//Задача 1.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Clear();
int MaxNum(int arg1, int arg2)
{    
    if(arg1 > arg2)
    {
        return arg1;
    }
    else
    {
        return arg2;
    }
}
int MinNum(int arg1, int arg2)
{
    if(arg1 < arg2)
    {
        return arg1;
    }
    else
    {
        return arg2;
    }
}
Console.Write("Введите первое чило число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе чило число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int big = MaxNum(num1, num2);
int small = MinNum(num1, num2);
Console.WriteLine($"Большее число - {big}  Меньшее число - {small}");
*/
// if(num1 > num2)
// {
//     Console.WriteLine("Max = " + num1);
//     Console.WriteLine("Min = " + num2);
// }
// else
// {
//     Console.WriteLine("Max = " + num2);
//     Console.WriteLine("Min = " + num1);
// }


//-------------------------------------------------------------------------------------------------

//Задача 2.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Clear();
int MaxNum(int arg1, int arg2, int arg3)
{
    int needNum = 0;
    if(arg1 > arg2 && arg1 > arg3)
        needNum = arg1;
    if(arg2 > arg1 && arg2 > arg3)
        needNum = arg2;
    if(arg3 > arg1 && arg3 > arg2)
        needNum = arg3;
    return needNum;
}
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int bigNum = MaxNum(num1, num2, num3);
Console.WriteLine("Максимальное число из введенных: " + bigNum);
// int max = 0;
// if(num1 > max)
//     max = num1;
// if(num2 > max)
//     max = num2;
// if(num3 > max)
//     max = num3;
//Console.Write("Максимальное число = " + max);
*/

//---------------------------------------------------------------------------------------------------------------

//Задача 3.
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Clear();
bool Chet(int arg)
{   
    if(arg % 2 == 0)
        return true;
    else
        return false;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool currNum = Chet(num);
Console.WriteLine("Это число четное? Ответ: " + currNum);
// if (num % 2 == 0)
//     Console.Write("Это число четное.");
// else
//     Console.Write("Это число не четное.");
*/

//-----------------------------------------------------------------------------------------------------------------

//Задача 4.
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
void NNum(int arg)
{
    int current = 1;    
    while(current <= arg)
    {        
        if(current % 2 == 0)
     {
         Console.Write(current + " ");        
     }
      current = current + 1;
  
    }    
}

Console.Write("Введите своё целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
NNum(num);

// Console.WriteLine("А вот и числа " + numbers);

// Console.Write("А вот и числа: ");

// int current = 1;

// while(current <= num)
// {
//     if(current % 2 == 0)
//     {
//         Console.Write(current + " ");        
//     }
//      current = current + 1;
  
