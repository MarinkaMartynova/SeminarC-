/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

Console.Write("Введите число строк массива:  ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива:  ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
Random random = new Random();
Console.WriteLine("Наш двумерный массив:");

FillArray(array);
PrintArray(array);
Console.WriteLine();

void FillArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++){    
        for (int j = 0; j < array.GetLength(1); j++ ){   
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

Console.WriteLine("Cреднее арифметическое: ");
for (int i = 0; i < n; i++)
{
  double average = 0;
  for (int j = 0; j < m; j++)
  {
    average += array[j, i];
  }
  average = Math.Round(average / m, 1);
  Console.WriteLine($"столбца № {i+1} {average}");
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++ ){
            Console.Write(array[i, j] + " ") ;
        }
        Console.WriteLine();
    }
}
