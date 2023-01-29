// Рекурсия и двумерные массивы

Console.Clear();

void FillMatrix (int [,] fill)
{
    for (int i = 0; i < fill.GetLength(0); i++)
{
    for (int j = 0; j < fill.GetLength(1); j++)
    fill[i,j] = new Random().Next(5,20);
}
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    Console.Write($"[{matrix[i,j]}]");
Console.WriteLine();
}
}

int [,] matr = new int [2,5];
FillMatrix (matr);
PrintMatrix (matr);