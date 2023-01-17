Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);


//Случайное число из отрезка [10,99] и показывает большую его цифру

Console.Clear();
int n = new Random().Next(10, 100); // [10, 99]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 10;
int n2 = n % 10;
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);