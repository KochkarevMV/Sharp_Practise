// Сбор черники - доп задача в домашке

// int n = Convert.ToInt32(Console.ReadLine()); // кол-во кустов
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine()); // кол-во ягод
 
// int maxSumma = 0;
// for (int i = 1; i < array.Length - 1; i++)
// {
//     int sum = array[i - 1] + array[i] + array[i + 1];
//     if (sum > maxSumma)
//         maxSumma = sum;
// }
// if (array[0] + array[1] + array[array.Length - 1] > maxSumma)
//     maxSumma = array[0] + array[1] + array[array.Length - 1];
 
// if (array[array.Length - 1] + array[array.Length - 2] + array[0] > maxSumma)
//     maxSumma = array[array.Length - 1] + array[array.Length - 2] + array[0];
 
// Console.WriteLine(maxSumma);



// String (char)
// Перевод символа в число через стринг
// string? stroka = Console.ReadLine();
// Console.WriteLine(Convert.ToInt32(stroka[0].ToString()) * 10);



// Массивы

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 11); // [-10, 10]

// Console.WriteLine($"Результат: {string.Join("             ", array)}");




// Функции и Процедуры

// Передача значений по ссылке.
// Войд (процедура) не передаёт значения. Поэтому чтобы процедура использовала входные данные, нужно исп ссылку (ref)

// void f(ref int n)
// {
//     n = n + 5;
// }

// int n = 101;
// f(ref n);
// Console.WriteLine(n);


// Заполнение массива в процедуре и изменение одного элемента. Вывод через join
// void f(int[] n)
// {
//     n[0] = n[0] + 5;
// }

// int[] n = {1, 2, 3, 4, 5};
// f(n);
// Console.WriteLine(string.Join(" ", n));



// Программа принимет 2 числа и находит максимум (через функцию)
// return завершает работу функции, поэтому в примере ниже проверка только одна, либо возвращает второе значение
// int f(int a, int b)
// {
//     if (a > b)
//         return a;
//     return b;
// }
// int a = 10, b = 7;
// int result = f(a, b);
// Console.WriteLine(result);


// ЗАДАЧА
// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму
// чисел от 1 до А.
// Здесь мы не исп цикл, а исп формулу арифметической прогрессии. нам нужны дробные числа, т.к. есть деление на числа.
// Console.Clear();
// Console.Write("Введите число: ");
// double n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Результат: {(1 + n) / 2 * n}");


// ЗАДАЧА
// Напишите программу, которая
// принимает на вход число и выдаёт количество
// цифр в числе.
// Мы будем удалять последнюю цифру числа и записывать это в счётчик
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine()),
// count = 0;
// while (n > 0)
// {
//     n = n / 10;
//     count++;
// }
// Console.WriteLine(count);


// ЗАДАЧА
// Напишите программу,
// которая принимает на вход число N и
// выдаёт произведение чисел от 1 до N.