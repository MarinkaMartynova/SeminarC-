// Решение задач на семинарах

//заготовка
/*
void FillArray(int[] array, int from, int to) {

    for ( int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(from, to+1);
    }
}

void PrintArray(int[] array){
    for ( int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}, ");

}
*/


/* Задача 31:
Задайте массив из 12 элементов, заполненный случайными числами
из промежутка [-9,9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
сумма отрицательных чисел равна -20
*/

/* 
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
*/

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




/* Задача 32: 
Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4,-8,8,2] -> [4,8,-8,-2]
*/


//мой вариант
/*
int[] array = new int[4];

for(int i = 0; i < array.Length; i++) {
    
    //Console.Write("Введите значение массива: ");
    //int a = Convert.ToInt32(Console.ReadLine()); 
    //array[i] = a;
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();
for(int i = 0; i < array.Length; i++) {
    
    array[i] =  array[i] * -1;
    Console.Write(array[i] + ", ");
}
*/


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



/* Задача 33: 
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6,7,19,345,3] -> нет
-3; массив [6,7,19,345,3] -> да
*/


//мой вариант
/*
int[] array = new int[5];
bool exist = false;

Console.Write("Какое число проверить?:  ");
int n = Convert.ToInt32(Console.ReadLine()); 

for(int i = 0; i < array.Length; i++) {
    
    //Console.Write("Введите значение массива: ");
    //int a = Convert.ToInt32(Console.ReadLine()); 
    //array[i] = a;
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++) {
    
    if(n == array[i]) {
        exist = true;
    }
}
if(exist == true){
    Console.Write("Значение присутствует в массиве");
}
else {
    Console.Write("Значение отсутствует в массиве");
}
*/

//пример с семинара
/*
int[] array = new Int32[10];
bool exist = false;
newArray(array);
PrintArray(array);

void newArray(int[] array, min, max) {
for(int i = 0; i < array.Length; i++) {
    
    Console.Write("Введите значение массива: ");
    int a = Convert.ToInt32(Console.ReadLine()); 
    array[i] = a;
    //array[i] = new Random().Next(0,10);
    //Console.Write(array[i] + ", ");
}
}
void PrintArray(int[] array){
    for ( int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}, ");

}
Console.WriteLine();*/



/*
newArray(array);
PrintArray(array);

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

string result = Poisk(array, number)? $"Число {number} входит в массив" : $"Число {number} не входит в массив";
Console.WriteLine(result);

bool Poisk(int[]array, int n) {
    bool h = false;
    for (int i = 0; i < array.Length; i++) {
        if(array[i] == n) {
            h = true;
            break;
        }
    }
    return h;
}
*/

/* Задача 35: 
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]
например(для 5 элементов):
[5,18,123,6,2] -> 1
[1,2,3,6,2] -> 0
[10,11,12,13,14] -> 5
*/
/*
int[] arr = new Int32[123];
fillMass(arr, -100, 100);
printArray(arr);
numFind(arr);

int[] fillMass (int[] arr, int from, int to);{
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(from, to + 1);
    }
    return arr[];
}
void PrintArray(int[] array) {
    for ( int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();     
}
void numFind(int[] array); {
    int sum = 0;
    for(int i = 0; i < array.Length; i++) {
        if (array[i] >= 10 && array[i] <= 99){
            sum++
        }
    }
    Console.WriteLine(sum);
}

*/

/*
int [] arr = new Int32[10];

fillMass(arr, -10, 120);
printArray(arr);
numFind(arr);

int[] fillMass(int[] array, int from, int to){
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

void printArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

void numFind(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        if( array[i] >= 10 && array[i] <= 99) {
            sum ++;
        }
    }
    Console.WriteLine(sum);
}
*/



/* Задача 37: 
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишем в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


int len = new Random().Next(9, 10);
Console.WriteLine(len);

int [] arr = new Int32[len];



double half = Math.Ceiling((Convert.ToDouble (len) / 2));
Console.WriteLine(half);


int [] arr2 = new Int32[Convert.ToInt32(half)];


fillMass(arr, -10, 10);
printArray(arr);
numFind(arr, arr2);
printArray(arr2);

int[] fillMass(int[] array, int from, int to){
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

void printArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int[] numFind(int[] array, int[] array2) {
    
    for (int i = 0; i < (array.Length) /2; i++) {
        array2[i] = array[i] * array[array.Length - i - 1];
    }
        if (array.Length % 2 != 0) {
        array2[array.Length / 2] = array[array.Length / 2];
    }
    return array2;
}

