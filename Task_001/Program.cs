﻿/*Задача 1
Задача 1: Напишите программу, которая на вход принимает два числа
и проверяет, является ли первое число квадратом второго.
                a = 5; b = 25 -> Да
                a = 2 b = 10 -> Нет
                a = 9 b = -3 -> Нет
                a = -3 b = 9 -> Да 
*/

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b*b)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет");    
}
