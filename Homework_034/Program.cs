/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/*
//вариант без FillArray , PrintArray

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



int [] arr = new int [4];

void FillArray(int[] array, int min, int max)
{
      for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max); 
    }
}
void PrintArray(int [] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

int QuantityEven(int[] array) {
    int quantity = 0;
    for (int i =0; i<array.Length; i++ ){
        if (array[i] % 2 == 0) {
            quantity++;
        }
    }
    return quantity;
}

FillArray(arr, 100, 1000);
PrintArray(arr);
Console.WriteLine();

int quantity = QuantityEven(arr);
Console.WriteLine($"Количество четных чисел в массиве: {quantity} ");



