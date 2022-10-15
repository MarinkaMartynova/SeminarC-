/* Задача 29: Напишите программу, которая задаёт массив 
произвольной длины, заполняет произвольными элементами 
и выводит их на экран. Длину массива и элементы массива 
можно задать рандомно или попросить пользователя
 ввести в консоли.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/* Пользователь вводит длину массива 
на выходе получает массив с рандомными значениями
*/
Console.Write("Введите число, для задания массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int [n];

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + ", ");
    }


// Пользователь вводит длину массива и задает значения элементам массива
/*
Console.Write("Введите число, для задания массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int [n];

for(int i = 0; i < array.Length; i++){
    Console.Write("Введите значение массива: ");
    int a = Convert.ToInt32(Console.ReadLine()); 
    array[i] = a;
    }

Console.WriteLine("Ваш массив: ");
for(int i = 0; i < array.Length; i++){
    Console.Write(array[i] + ", ");
    }   
*/

/* Выводим длину массива, задаем значения элементам массива 
и выводим в виде таблицы обозначая порядковый номер значений

Console.Write("Введите число, для задания массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int [n];

for(int i = 0; i < array.Length; i++){
    Console.Write("Введите значение массива: ");
    int a = Convert.ToInt32(Console.ReadLine()); 
    array[i] = a;
    }

Console.WriteLine("Ваш массив: ");
for(int i = 0; i < array.Length; i++){
    int count = i+1;
    Console.WriteLine("элемент " +  count  + "   " + array[i]);
    }   
    */