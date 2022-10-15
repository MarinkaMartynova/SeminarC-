/* Задача 30: Напишите программу, которая выводит массив из 
8 элементов, заполняющий нулями и единицами 
в случайном порядке.
{1,0,1,1,0,1,0,0}
*/
// 1 вариант
///*
int[] array = new int[8];
void Itog(){

for(int i = 0; i < array.Length; i++) {
    
    array[i] = new Random().Next(0,2);

    Console.Write(array[i] + ", ");
}
}
Itog();  
//*/

//2 вариант 
/*
int[] arr = new int[8];

void newArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}

void PrintArray(int[]array)
{
    for (int i=0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < (array.Length-1)) Console.Write($", ");

    }
    Console.WriteLine();
}
newArray(arr);
PrintArray(arr);

*/