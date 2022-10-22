/* Задача 32: 
Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4,-8,8,2] -> [4,8,-8,-2]
*/


//мой вариант
///*
int[] array = new int[4];

for(int i = 0; i < array.Length; i++) {
    
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
for(int i = 0; i < array.Length; i++) {
    
    array[i] =  array[i] * -1;
    Console.Write(array[i] + ", ");
}
//*/


// пример с семинара
/*
int[] array = new Int32 [4];

randomFilling(array, -9, 10);
arrayOutput(array);
signChange(array);
arrayOutput(array);

void signChange(int[] arr) {

    for ( int i = 0; i < arr.Length; i++) {
        arr[i] = arr[i] * -1;
    }    
}

void randomFilling(int[] arr, int min, int max) {

    for ( int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(min, max);
    }   
}

void arrayOutput(int[] arr) {

    for ( int i = 0; i < arr.Length; i++) {

        Console.Write($"{arr[i]}");
        if(i < (arr.Length - 1)) Console.Write($", ");        
    }
    Console.WriteLine();
}
*/