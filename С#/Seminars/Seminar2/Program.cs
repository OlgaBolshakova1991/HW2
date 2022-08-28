//Написать программу, которая выводит случайное число из отрезка от 10 до 99 и показывает наибольшую цифру данного числа.

/*
int FindBiggerDigit(int number);
{
    int ed = number % 10;
    int dec = number / 10;

    int max;
    if(ed > dec) max = ed;
    else max = dec;

    return max;
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerDigit(randNumber);

Console.WriteLine($"Bigger digit of {randNumber} is {biggerDigit}");

*/

// Задача. Написать программу, которая выводитслучайное трухзначное число и удаляет вторую цифру этого числа.
 /*

int FindSecondDigit(int number)
{

    int ed = number % 10;
    int hundred = number / 100;

    int newDigit = hundred * 10 + ed;

    return newDigit;

}



int randNumber = new Random().Next(100, 1000);
int secondDigit = FindSecondDigit(randNumber);
Console.WriteLine($"Полученное число от числа {randNumber} - {secondDigit}");
*/

//Задача. Написать программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому числу.


void TwoNumbers(int num1, int num2);
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine($"{num2} multiple {num1}");
    }
    else
    {
        int div;
        div = num2 % num1;
        Console.WriteLine($"Remainder is {div}");

    }
}

Console.Write("Enter first value: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second value: ");
int n2 = Convert.ToInt32(Console.ReadLine());

TwoNumbers(n1, n2);

