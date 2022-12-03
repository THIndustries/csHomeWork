//Задача 1.
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое чило число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе чило число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Max = " + num1);
    Console.WriteLine("Min = " + num2);
}
else
{
    Console.WriteLine("Max = " + num2);
    Console.WriteLine("Min = " + num1);
}
*/

//-------------------------------------------------------------------------------------------------

//Задача 2.
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if(num1 > max)
    max = num1;
if(num2 > max)
    max = num2;
if(num3 > max)
    max = num3;

Console.Write("Максимальное число = " + max);
*/

//---------------------------------------------------------------------------------------------------------------

//Задача 3.
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.Write("Это число четное.");
else
    Console.Write("Это число не четное.");
*/

//-----------------------------------------------------------------------------------------------------------------

//Задача 4.
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите своё целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("А вот и числа: ");

int current = 1;

while(current <= num)
{
    if(current % 2 == 0)
    {
        Console.Write(current + " ");        
    }
     current = current + 1;
  
}
*/
