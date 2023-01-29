// Рекурсия и двумерные массивы

Console.Clear();
string [,] words = new string [2,5];

for (int i = 0; i < words.GetLength(0); i++)
{
    for (int j = 0; j < words.GetLength(1); j++)
    Console.Write($"[{words[i,j]}]");
Console.WriteLine();
}