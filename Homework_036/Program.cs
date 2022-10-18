/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
//Конкретный массив
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


//число элементов вводит пользователь
Console.Write($"Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());


int RandomNumbers(int number, int min, int max)
  {
  int[] array = new int[number];
  int sum = 0;
  Console.Write("Наш массив: ");

    for (int i = 0; i < array.Length; i++ ){
      array[i] = new Random().Next(min, max);

      Console.Write(array[i] + " ");

      if (i % 2 != 0)
      {
        sum = sum + array[i];
      }
    }
  return sum;
  }

int array =  RandomNumbers(number, 1, 10);

Console.WriteLine();
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях:  " + array);
