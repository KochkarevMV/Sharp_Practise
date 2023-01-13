Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int m = n * (-1);
while (m <= n)
{
    Console.Write($"{m} ");
    m = m + 1; // m++;
}
