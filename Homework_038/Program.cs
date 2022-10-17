/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76


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

/*
Console.WriteLine("Исходный массив: ");
    
    
    double[] array = new double[5];
    Random random = new Random();
    double diff = 0;
    
    for(int i = 0; i < 5; i++)
		{
			array[i] = random.NextDouble() * 100;
			Console.Write(Math.Round(array[i]) + ", ");
		}

Console.WriteLine("Расстояние между точками равно: " + Math.Round(distance, 2));
*/