//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.Clear();
int SeccondNum(int arg1)
{
    int needNum = (arg1 / 10) % 10;
    return needNum;
}

Console.WriteLine("Сейчас я сделаю с вашим числом магию.");
Console.Write("Введите своё трехзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
if(number >= 100 && number <1000)
{
    int result = SeccondNum(number);
    Console.Write($"Вторая цифра от вашего числа: {result}");
}
else
{
    Console.Write("Вы ввели не трехзначное число, попробуйте ещё раз.");
}
*/

//--------------------------------------------------------------------------------------------------------------------

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Clear();
int CutNumber(int arg)
{
    int thirdNum = 0;
        while(arg > 999 || arg < 100)
    {
        if (arg > 999)
        {
            arg = arg / 10;
        }
        if (arg < 100)
        {
            return -1;
        }
    
    }
    thirdNum = arg % 10;
    return thirdNum;    
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = CutNumber(num);
Console.Write("Нужное число: " + result);
*/

//--------------------------------------------------------------------------------------------------------------------

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
/*
Console.Clear();
bool Weekends(int arg)
{
    while(arg > 0 && arg < 8)
    {
        if(arg == 6 || arg == 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    return false;
}
Console.Write("Введите цифру от 1 до 7: ");
int weekNum = Convert.ToInt32(Console.ReadLine());
bool result = Weekends(weekNum);
Console.WriteLine(result);
*/