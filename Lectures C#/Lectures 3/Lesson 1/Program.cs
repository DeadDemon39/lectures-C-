// 1 вид метода

void Method1()
{
   Console.WriteLine("Автор ...");
}

//Method1(); // - призыв этого метода



// 2 вид метода

// void Method2( string msg) // - метод который принимает какие либо аргументы но ничего не возвращает
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения"); // - первый вариант


// void Method2( string msg, int count) // - метод который принимает какие либо аргументы но ничего не возвращает
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg); // -msg - message
//         i++;
//     }
// }

// Method2("Текст сообщения", 4); // - указывается переменная msg (message) а через (,) количество повторений 
// Method2(msg: "Текст сообщения", count: 4); // - так же можно писать и наоборот




// 3 вид метода

// int Method3() // - ничего не принимает но возвращает
// {
//     return DateTime.Now.Year; // - DateTime - метод
// }
// int year = Method3();
// Console.WriteLine(year);



// 4 вид метода - принимает и возвращает


// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // - пустая строка (еще ее можно записать как "",) вариант в коде более правильный

//     while (i < count)
//     {
//        result = result + text; 
//        i++;
//     }
//     return result;
// }
// string res = Method4(10, "вроде работает ");
// Console.WriteLine(res);






// string Method4(int count, string text)
// {
    
//     string result = String.Empty; // - пустая строка (еще ее можно записать как "",) вариант в коде более правильный
//     for (int i = 0; i < count; i++)
//     {
//        result = result + text; 
//     }
//     return result;
// }
// string res = Method4(10, "вроде работает ");
// Console.WriteLine(res);                          // - задействован цикл FOR




for (int i = 2; i <= 10; i++)
{
   for (int j = 2; j <=10; j++)
   {
    Console.WriteLine($"{i} x {j} = {i * j}");
   } 
   Console.WriteLine();
}
