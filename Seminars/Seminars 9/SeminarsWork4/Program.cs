/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели некоректное число. Повторите ввод:");
        }
    }
    return result;   
}

int Power(int a, int b)
{
    if (b == 1)
        return a;
    else
        return a * Power(a, b - 1);
}

int result = Power(3, 5);
Console.WriteLine(result);

// https://www.sql-ex.ru/