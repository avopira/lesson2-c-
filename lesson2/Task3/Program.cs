// int n = 10;
int[] arr = { 2, 5, 7, 4, 8, 35, 1, 3, 8, 5};
int i = 0;

while (i < arr.Length)
{
    if(arr[i] % 2 ==0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}