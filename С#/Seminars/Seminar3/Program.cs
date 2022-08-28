//Семинар 3.
//Задача. Написать программу, которая принимает на вход координаты точки x, y (ненулевые) и выдает номер четверти плоскости, в которой находится эта точка.

int  FindQuadrant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input x coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
int quadrant = FindQuadrant(xA, yA);
Console.WriteLine("Num of quad is " + quadrant);


//Задача.  Написать программу, которая по заданному номеру четверти показывает диапазон  возможных координат точек в этой четверти.
/*
void FindInterval(int num)
{
    if(num ==1) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x > 0, y > 0");
    if(num ==2) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x < 0, y > 0");
    if(num ==3) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x < 0, y < 0");
    if(num ==4) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x > 0, y < 0");
    if(num < 0 || num > 4) Console.WriteLine(“Четверти с таким номером не существует”);
}
Console.Write("Введите порядковый номер четверти:  ");
int quad = Convert.ToInt32(Console.ReadLine());
FindInterval(quad);

*/

//Задача. Написать программу, которая принимает на вход некоторое число и выдает квадраты чисел от 1 до этого числа.  

/*
Void Quad(int n)
{
    int i=1;
while(I <= n)
{
    Console.Write($”{i * i}, “);
    i++;
}
}
Console.Write(“Введите натуральное число: “);
int number = Convert.ToInt32(Console.ReadLine());
Quad(number);
*/

//Задача. Написать программу, которая принимает на вход координаты двух точек  и находит расстояние между ними на плоскости.

/*
double FindDDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x2 – x1) * (x2 – x1) + (y2 – y1) * (y2 – y1));
}
Console.WriteLine(“Enter 1 dot “);
double xA = Convert.ToDouble(Console.ReadLine());
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(“Enter 2 dot “);
double xB = Convert.ToDouble(Console.ReadLine());
double xB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(xA, yA, xB, yB);
Console.WriteLine($”dist is {dist}”);

*/

