// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 12321
/*
Console.Clear();
bool Polindrom(int arg)
{            
        int leftNum1 = arg / 10000; //1
        int leftNum12 = arg / 1000; //12
        int leftNum2 = leftNum12 % 10; //2
        
        int rightNum5 = arg % 10; //1
        int rightNum45 = arg % 100; //21
        int rightNum4 = rightNum45 / 10; //2 
        

        if(leftNum1 == rightNum5 && leftNum2 == rightNum4)           
        return true; 
        else
        return false;
}                                                      
                                    
    
Console.Write("Введите ваше пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = Polindrom (num);
if(num >=10000 && num < 100000)
    Console.WriteLine(result);
else
    Console.Write("Введите именно пятизначное число.");
*/

//-----------------------------------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
Console.Clear();
double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return length;
}

Console.Write("Введите Х первой точки: ");
double numx1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите У первой точки: ");
double numy1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z первой точки: ");
double numz1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите Х второй точки: ");
double numx2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите У второй точки: ");
double numy2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z второй точки: ");
double numz2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Round(Distance(numx1, numy1, numz1, numx2, numy2, numz2), 2);
Console.WriteLine("Расстояние между точками: " + result) ;
*/

//-----------------------------------------------------------------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Clear();
void Cub(int arg)
{   
    
    int current = 1;
     
        while(current <= arg)
    {
        double cube = Math.Pow(current, 3);
        Console.Write(cube + " ");
        current ++;
    }
    
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cub(num);
*/
