/* Задача 31:
Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных чисел равна -20
*/

///* 
//мой вариант

int[] array = new int[12];
int sumPos = 0;
int sumNeg = 0;

for(int i = 0; i < array.Length; i++) {
    
    //Console.Write("Введите значение массива: ");
    //int a = Convert.ToInt32(Console.ReadLine()); 
    //array[i] = a;
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + ", ");
}
for(int i = 0; i < array.Length; i++) {
    if(array[i] > 0){
        sumPos = sumPos + array[i];
    }
    else {
        if(array[i] < 0) {
            sumNeg = sumNeg + array[i];
        }
    }
}
Console.WriteLine();
Console.WriteLine("Сумма положительных элементов: " + sumPos + ", ");
Console.WriteLine("Сумма отрицательных элементов: " + sumNeg + ", ");
//*/

/*
//пример с семинара 

int[] array = new Int32[12];

int sumPos = 0;
int sumNeg = 0;

randomFilling(array, -9, 9);
arrayOutput(array);

for(int i = 0; i < array.Length; i++){
    if (array[i] < 0){
        sumNeg += array[i];
    }
    else {
        sumPos += array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел {sumPos}, " + 
                  $"Сумма отрицательных чисел {sumNeg}, ");

void randomFilling(int[] array, int min, int max) {
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(min, max);
    }
    return;
}

void arrayOutput(int[] array){
    for ( int i = 0; i < array.Length; i++) {

        Console.Write($"{array[i]}");
        if(i < (array.Length - 1)) Console.Write($", ");        
    }
    Console.WriteLine();
}
*/