/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

[1,7] -> такого элемента в массиве нет
*/

Console.Write("Введите строку:");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int column = Convert.ToInt32(Console.ReadLine()) - 1;
int m = 3; // размер массива
int n = 4; // размер массива
Random random = new Random();
int[,] arr = new int[m, n];
Console.WriteLine("Наш массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
         Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
if (row < 0 | row > arr.GetLength(0) - 1 | column < 0 | column > arr.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[row, column]);
}
Console.ReadLine();
 
