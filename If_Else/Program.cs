Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "максим")
{
    Console.WriteLine("Welcome back, sir");
}
else
{
    Console.Write("Welcome, ");
    Console.Write(username);
}