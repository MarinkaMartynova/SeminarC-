/*Задача 26: Напишите программу, 
которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

//1 вариант мой
//*
Console.Write("Enter the number of:  ");
int number = Convert.ToInt32 (Console.ReadLine());
int count = 0;
while( number > 0 )
{
    number = number / 10;
    count++;
}
Console.WriteLine(count);
//*/

//второе решение
/*
Console.Write ("Input N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"There are {Math.Ceiling(Math.Log10(n))} digits");
*/


//3 вариант
/*
Console.WriteLine("Введите число ");

int N = int.Parse(Console.ReadLine());
int count = 0;

while (N>0)
{
    count+=1;
    N = N/10;
}
Console.WriteLine($"{count}");     //Anton Semenov   
*/


// вариант преподавателя
/*
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int count = 0;

while (a != 0)
{
   a = a / 10;
    count++;
}
Console.WriteLine(count);
*/