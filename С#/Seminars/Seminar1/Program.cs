// Задача. Написать программу, которая принимает на вход число и выдает его квадрат.
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int kvadrat = number * number;
Console.WriteLine($"The quad of {number} is {kvadrat}");
*/




//Задача. Написать программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int kvadrat = number2 * number2;

if(number1 == kvadrat)
{
    Console.Write("Первое число является квадратом второго");

}
else
{
    Console.Write("Первое число НЕ является квадратом второго");

}

*/




//Задача. Написать программу, которая на вход принимает одно число и показывает все целые числа от -n до n

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while(current <= number)
{
    Console.Write(current + " ");
    current++;
}

*/