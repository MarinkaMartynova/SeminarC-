/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
Console.WriteLine("Исходный массив: ");

int sum = 0;
int[] array = new int [5];
		
for(int i = 0; i < 5; i++)
{
	array[i] = new Random().Next(-10, 10);
	Console.Write(array[i] + ", ");
}
		 
for(int i = 0; i < 5; i++)
{
	if (i % 2 == 1){
	sum += array[i];
	}
			
}	
Console.WriteLine(" \n");
Console.WriteLine("Сумму элементов, стоящих на нечётных позициях:  " + sum);
Console.ReadKey();
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