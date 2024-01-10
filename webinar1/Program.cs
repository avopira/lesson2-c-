// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет



// Console.WriteLine("Enter number");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
//    Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }




// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2




// Console.WriteLine("Enter number");
// int num = Convert.ToInt32(Console.ReadLine());

// int negNum = num * -1;

// while(num >= negNum)
// {
//     Console.WriteLine(negNum);
//     negNum = negNum + 1;
// }




// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17


Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num/100;

int num3 = num %10;

int result = num1+num3;

Console.WriteLine("Sum = \t"+result+" ff"); // Конкатенация
Console.WriteLine($"Sum = {result} ff"); // Интерполяция
Console.Write("  /"" /");