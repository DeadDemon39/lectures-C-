﻿/*
Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/




 Console.WriteLine("Введите число:");
 int a = Convert.ToInt32(Console.ReadLine());

 int b = a % 10;   //ДАННЫЙ ПРИМЕР БУДЕТ РАБОТАТЬ ТОЛЬКО ЕСЛИ ТЫ РАБОТАЕШЬ С ЦИФРАМИ А НЕ СО СТРОКАМИ (ОПРЕДЕЛЕНИЕ НУЖНОЙ ЦИФРЫ ПУТЕМ ДЕЛЕНИЯ С ОСТАТКОМ)

 Console.WriteLine(b);