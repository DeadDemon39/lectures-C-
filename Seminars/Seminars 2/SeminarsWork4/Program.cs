/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
7 и 23. (что бы узнать это число надо перемножить одно на другое)
*/

Console.WriteLine("Введите число");
int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number; 
}

int firstNumber = GetNumber();


if(firstNumber % 7 == 0 && firstNumber % 23 == 0)   // ПОДЕЛИТЬ СРАЗУ НА ДВА ЧИСЛА &&
{
    Console.WriteLine($"второе число кратно первому.");
}
else
{
    Console.Write("не кратно");
    
}