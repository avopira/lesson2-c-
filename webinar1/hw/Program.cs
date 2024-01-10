// int a = 6;
// int b = 7;
// int c = 9;

// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {   
//     max = c;
// }
// Console.WriteLine(max);

int num = 5;
int number = 1;
while (number <= num)
{ 
  if (number % 2 ==0)  
  {
    Console.Write($"{number}\t");
    number++;
  } 
  else
  { 
    number++;
  }
}