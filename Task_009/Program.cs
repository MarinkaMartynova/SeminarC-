/* Напишите программу, которая выводит случайное число из отрезка (10,99) и показывает наибольшую цифру числа
78 - 8
12 -2
85- 8
*/

/* 1 var
int n = 0;
n = new Random().Next(10,99);  // метод для выборки случайных чисел. 
//new - новый объект рандома и передаем с помощью нексту в диапазоне, где нужно находить число

Console.WriteLine (n);     //для запуска

int first = n/10;           //первое число мы получим если поделим на 10
int second = n%10;          // вторая цифра числа находится делением на остаток

Console.WriteLine(first);    //выводим на экран 1 число
Console.WriteLine(second);    //выводим на экран 2 число
*/

// Задание 009
int a = new Random().Next(10,99);
    Console.WriteLine(a);
int first = a / 10;
int second = a %10;
if (first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}
