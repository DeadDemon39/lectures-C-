// // /* Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное
// // на само себя).

// // Например:
// // 4 -> 16
// // -3 -> 9
// // -7 -> 49
// // */


Console.WriteLine("Введите число:");

 string numberStr = Console.ReadLine(); // данные приходят в формате string!!!

 int number = Convert.ToInt32(numberStr); // Convert.ToInt32() - ковертер (Convert.ToDoble) - конверт для не целых чисел

 int result = number * number;

 Console.WriteLine($"квадрат числа {number} = {result}");