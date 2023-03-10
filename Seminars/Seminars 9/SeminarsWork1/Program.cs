/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
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

void NumberRec(int numberN, int i) // РЕКУРСИЯ
{
    if (i <= numberN)
    {
        Console.Write($"{i}, "); 
        i++;
        NumberRec(numberN, i);      
    }   
}

int numberN = GetNumber("Введите число:");
int i = 1;
NumberRec(numberN, i);
// РЕКУРСИЯ!!!!