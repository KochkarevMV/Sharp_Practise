// Найти в какой четверти в осях XY находится точка по введённым координатам.
// Координаты не должны быть на 0 (не пересекаются оси)

// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0 || y == 0)
// {
//     Console.WriteLine("Вы ошиблись! Введите координаты заново!");
//     Console.Write("Введите координату X: ");
//     x = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите координату Y: ");
//     y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");



// Теперь наоборот. Принимает четверть и показываем диапазон возможных координат

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 4)
// {
//     Console.WriteLine("Вы ошиблись!\nВведите число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// if (n == 1)
//     Console.WriteLine("x(0, +∞) and y(0, +∞)");
// else if (n == 2)
//     Console.WriteLine("x -∞, 0 and y 0, +∞ ");
// else if (n == 3)
//     Console.WriteLine("x -∞, 0 and y -∞, 0 ");
// else
//     Console.WriteLine("x(0, +∞) and y(-∞, 0)");

// Напишите программу,
// которая принимает на вход координаты
// двух точек и находит расстояние между
// ними в 2D пространстве.
// Console.Clear();
// Console.Write("Введите X1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите X2: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите Y2: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// double l = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y1 - y2, 2)), 2);
// Console.WriteLine(l);

// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу квадратов чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
Console.Write($"{Math.Pow(i, 2)} ");
