Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "alex")  //#ToLower - приравнивает все буквы к маленьким
   { 
    Console.Write("ok, you Alex");
   }
   else
   {
    Console.Write("ups, one problem ");
    Console.WriteLine(username);
   }