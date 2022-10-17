/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/*
int[] arr = new int[4];
int even = 0;
Random rnd = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 4; i++) 
{
    arr[i] = rnd.Next(100, 1000);
    //Console.Write("{0} ", arr[i]);
}
foreach(int element in arr)
{
    Console.Write("{0} ", element);
    if (element % 2 == 0)
    {
        even++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел: {0}", even);
*/

void FillArray(int[] array, int from, int to)
{
      for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1); 
    }
}

void PrintArray(int[] array)
{
       for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); 
    }
    System.Console.Write($"{array[array.Length - 1]}"); 
}