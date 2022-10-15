/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
                 3, 5 -> 243 (3⁵)
                 2, 4 -> 16
*/
Console.Write("Введите число:   ") ;
int num = int.Parse(Console.ReadLine()) ; //num - число
Console.Write("Введите сетпень: ") ;
int power = int.Parse(Console.ReadLine()) ; //power- степень
Console.WriteLine(Math.Pow(num,power));
