/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int reminder, sum = 0;
int temp = number;
while (number > 0)
{
    reminder = number % 10;
    sum = (sum * 10) + reminder;
    number = number / 10; 
}
if (temp == sum)
{
    Console.WriteLine($"Число {temp} является Палиндромом.");
}
else
{
    Console.WriteLine($"Число {temp} не является Палиндромом.");
}
Console.ReadKey();

