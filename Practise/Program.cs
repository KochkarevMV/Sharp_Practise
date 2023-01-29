// Рекурсия и двумерные массивы



// Заполнение и распечатка двумерного массива

// Console.Clear();

// void FillMatrix (int [,] fill)
// {
//     for (int i = 0; i < fill.GetLength(0); i++)
// {
//     for (int j = 0; j < fill.GetLength(1); j++)
//     fill[i,j] = new Random().Next(5,20);
// }
// }

// void PrintMatrix (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     Console.Write($"[{matrix[i,j]}]");
// Console.WriteLine();
// }
// }

// int [,] matr = new int [2,5];
// FillMatrix (matr);
// PrintMatrix (matr);


// Факториал через метод

Console.Clear();
double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 20; i++)
// int = 0 в начале приведёт к бесконечной рекурсии и ошибке Stack Overflow
{
    Console.WriteLine($" {i}! = {Factorial(i)}");
}
