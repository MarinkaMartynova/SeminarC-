/* Задача 54.1 : 
Задайте двумерный массив. Напишите программу, 
которая упорядочит элементы по убыванию (или возрастанию).
*/

Console.Write("number of rows: ");
int m = int.Parse(Console.ReadLine());
Console.Write("number of columns: ");
int n = int.Parse(Console.ReadLine());

int[, ] array = new int[m, n];
Random random = new Random();
Console.WriteLine("two dimensional array: ");

void FillArray(int[,]array){
    for (int i = 0; i < array.GetLength(0); i++){    
        for (int j = 0; j < array.GetLength(1); j++ ){   
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++ ){
            Console.Write(array[i, j] + " ") ;
        }
        Console.WriteLine();
    }
}

//сортировка по возрастанию по столбцам
void SortColumnAscending(int[,] array){
    for(int j = 0; j < array.GetLength(1); j++){
        for(int i = 0; i < array.GetLength(0); i++){
            for(int t = i + 1; t < array.GetLength(0); t++){
                if(array[i, j] > array[t, j]){
                    int temp = array[i, j];
                    array[i, j] = array[t, j];
                    array[t, j] = temp;
                }              
            }
        }
    }
}

//сортировка по убыванию по столбцам
void SortColumnDescending(int[,] array){
    for(int j = 0; j < array.GetLength(1); j++){
        for(int i = 0; i < array.GetLength(0); i++){
            for(int t = i + 1; t < array.GetLength(0); t++){
                if(array[i, j] < array[t, j]){
                    int temp = array[i, j];
                    array[i, j] = array[t, j];
                    array[t, j] = temp;
                }              
            }
        }
    }
}


FillArray (array);
PrintArray(array);
Console.WriteLine();
SortColumnAscending(array);
PrintArray(array);
Console.WriteLine();
SortColumnDescending(array);
PrintArray(array);
Console.WriteLine();
