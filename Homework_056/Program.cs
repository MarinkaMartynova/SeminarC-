/* Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("введите размер строк массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите размер столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];

Console.WriteLine("");
FillArray(array);
PrintArray(array);
Console.WriteLine("");
int minsum = Int32.MaxValue;
int index = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}

Console.WriteLine("строка с наименьшей суммой элементов под номером: " + (index) + ", с суммой элементов равной: " + (minsum));

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}