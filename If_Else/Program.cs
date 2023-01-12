Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == Максим)
{
    Console.WriteLine("Welcome back, sir");
}
else
{
    Console.Write("Welcome, nice to see you, ");
    Console.Write(username);
}