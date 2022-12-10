//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecoundDigit(int number)
{
   while(number>100)
   {
      number /= 10;
   }
   number %= 10;
   return number;
}
Console.Write("Please, write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Secound digit in number {number} is: " + SecoundDigit(number));




//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int number)
{
   if(number>100)
   {
      while(number>1000)
      {
         number /= 10;
      }
   }
   else return -1;
   number %= 100;
   number %=10;
   return number;
}

Console.Write("Please, write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = ThirdDigit(number);
if(digit == -1)
   Console.WriteLine("There's is no third digit in number " + number);
else
   Console.WriteLine($"Third digit in number {number} is: " + digit);




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void IsWeekend(int day)
{
   if(day<1 || day>7)
      Console.WriteLine("No day equal your number. Please, use Gregorian calendar.");
   else
   {
      if(day == 7 || day == 6) 
         Console.WriteLine("Hurrah! It's weekend.");
      else
         Console.WriteLine("Sorry, but it's a workday.");
   }
}

Console.Write("Please, enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
IsWeekend(number);