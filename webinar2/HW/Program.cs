// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 ==0 && number % 23 == 0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }


// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Enter X number");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter Y number");
// int Y = Convert.ToInt32(Console.ReadLine());

// int quarter = 0;

// if (X > 0 && Y > 0)
// {
//     quarter = quarter + 1;
// }
// if (X > 0 && Y < 0)
// {
//     quarter = quarter + 4;
// }
// if (X < 0 && Y > 0)
// {
//     quarter = quarter + 2;
// }
// if (X < 0 && Y < 0)
// {
//     quarter = quarter + 3;
// }
// Console.WriteLine(quarter);


// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num  = new Random().Next(10, 100);
// Console.WriteLine(num);

// int num1 = num/ 10;
// int num2 = num% 10;

// int max = num1 > num2 ? num1 : num2;
// Console.WriteLine(max);


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}
