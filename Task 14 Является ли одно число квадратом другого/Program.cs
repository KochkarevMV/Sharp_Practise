// Напишите программу, которая
// принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.Clear();
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число:");
int b = Convert.ToInt32(Console.ReadLine()); 

if (a*a == b)
Console.WriteLine("1ое число - квадрат второго");
else if (b*b == a)
Console.WriteLine("2ое число - квадрат второго");
else
Console.WriteLine("Квадратов нет");