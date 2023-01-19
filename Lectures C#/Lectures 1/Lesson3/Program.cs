/*
Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/


 Console.WriteLine("Введите число");

 int a = Convert.ToInt32(Console.ReadLine());

 int i = a;

 if (i == 1)
 {
     Console.WriteLine("Понедельник");
 }
 else if (i == 2)
 {
     Console.WriteLine("Вторинк");
 }
 else if (i == 3)
 {
     Console.WriteLine("Среда");
 }
 else if (i == 4)
 {
     Console.WriteLine("Четверг");
 }
 else if (i == 5)
 {
     Console.WriteLine("Пятница");
 }
 else if (i == 6)
 {
     Console.WriteLine("Суббота");
 }
 else if (i == 7)
 {
     Console.WriteLine("Воскресенье");
 }
 else  //else     ТЫ ИСПОЛЬЗУЕШЬ ТОЛЬКО ДЛЯ СВОЕГО ПЕРВОГО if (для остальных условий ты успользуешь else if)
 {
     Console.WriteLine("Введите число от 1 или 7");
 }