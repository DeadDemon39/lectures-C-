/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.WriteLine("Введите первое число:");
int firstnumber = GetNumber();

Console.WriteLine("Введите второе число:");
int secondnumber = GetNumber();

if(firstnumber * firstnumber == secondnumber)
{
    Console.WriteLine("число является квадратом другого числа");
}
else
{
    Console.WriteLine("число не является квадратом другого числа");
}
