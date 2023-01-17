//Последняя цифра числа
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 10);


//Случайное число из отрезка [10,99] и показывает большую его цифру

Console.Clear();
int n = new Random().Next(10, 100); // [10, 99]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 10; // находит первую цифру случайного числа
int n2 = n % 10; // находит вторую цифру случайного числа
if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);


//Случайное трехзначное число и удаляет вторую её цифру

Console.Clear();
int n = new Random().Next(100, 1000); // [100, 999]
Console.WriteLine($"Случайное число: {n}");
int n1 = n / 100;
int n3 = n % 10;
Console.WriteLine(n1 * 10 + n3);