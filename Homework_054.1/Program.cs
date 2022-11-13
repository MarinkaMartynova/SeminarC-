/* Задача 54.1 : 
Задайте двумерный массив. Напишите программу, 
которая упорядочит элементы по убыванию (или возрастанию).
*/

/*
Console.Write("number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("number of columns: ");
int column = int.Parse(Console.ReadLine());

int[, ] array = new int[row, column];
Random random = new Random();
Console.Write("two dimensional array: ");


void fillArray(int[,]array){
    for (int i = 0; i < array.GetLength(0); i++){    
        for (int j = 0; j < array.GetLength(1); j++ ){   
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void twoDarray(int[,] arr, int[] arr2)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = arr2[column * i+j];
        }
    }
}

void arrayOutput(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine("  ");
    }
    Console.WriteLine(" ");
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length-1)) Console.Write($", ");
        
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}
fillArray (array);

Console.WriteLine();
arrayOutput(array);
Console.WriteLine("from two dimensinal array to one dimensional: ");
int[] temp = array.Cast<int>().ToArray();
printArray(temp);
Console.WriteLine("Sort ascending:");
Array.Sort(temp);
printArray(temp);
twoDarray(array, temp);
Console.WriteLine("Sort");
arrayOutput(array);
*/


Console.Write("number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("number of columns: ");
int column = int.Parse(Console.ReadLine());

int[, ] array = new int[row, column];
Random random = new Random();
Console.Write("two dimensional array: ");


void fillArray(int[,]array){
    for (int i = 0; i < array.GetLength(0); i++){    
        for (int j = 0; j < array.GetLength(1); j++ ){   
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void twoDarray(int[,] arr, int[] arr2)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = arr2[column * i+j];
        }
    }
}

void arrayOutput(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine("  ");
    }
    Console.WriteLine(" ");
}

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length-1)) Console.Write($", ");
        
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}
fillArray (array);

Console.WriteLine();
arrayOutput(array);
Console.WriteLine("from two dimensinal array to one dimensional: ");
int[] temp = array.Cast<int>().ToArray();
printArray(temp);
Console.WriteLine("Sort descending:");
Array.Sort(temp);
Array.Reverse(temp);
printArray(temp);
twoDarray(array, temp);
Console.WriteLine("Sort");
arrayOutput(array);

