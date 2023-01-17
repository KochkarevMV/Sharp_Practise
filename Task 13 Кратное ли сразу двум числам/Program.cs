// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 161 == 0)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Если кратно 7 или 23
Console.Clear();
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine()); 
if (a%7 == 0 && a%23 == 0)
{
    Console.WriteLine("Число кратно семи и двадцати трём");
else if (a%7 == 0 && a%23 != 0)
Console.WriteLine("Число кратно семи, но не кратно двадцати трём");
else if (a%7 != 0 && a%23 == 0)
Console.WriteLine("Число не кратно семи, но кратно двадцати трём");
else
Console.WriteLine("Число не кратно семи, и не кратно двадцати трём");
}