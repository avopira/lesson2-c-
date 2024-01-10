// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// Console.WriteLine("Enter number");

// // int num = int.Parse(Console.ReadLine());
// int num = Convert.ToInt32(Console.ReadLine());

// int num1 =  num/100;  
// int num3 = num% 10;   

// int result = num1*10+num3;  
// System.Console.WriteLine(result);




// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int num  = new Random().Next(100, 1000);
// Console.WriteLine(num);


// int num2 =  num/10 %10;  
// int num3 = num% 10;   
// int result =1;

// while(num3>0)
// {
//     result = result*num2;
//     num3= num3 -1;
// }

// System.Console.WriteLine(result);




// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// Console.WriteLine("Enter number");
// // int num = int.Parse(Console.ReadLine());
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number");
// // int num = int.Parse(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 % num2==0)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine($"No, {num1% num2}");
// }




// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет


Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

if(num>=100)
{
    int result= num /100 %10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("No third number");
}