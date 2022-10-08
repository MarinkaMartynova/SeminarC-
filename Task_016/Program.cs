/* 16. Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
/*
Console.Write( "Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a*a ==b || b*b ==a) {
    Console.WriteLine("Одно число является квадратом второго");
}
else {
    Console.WriteLine("Не является квадратом");
}*/

/**/
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if( a * a ==b) {
    Console.WriteLine("b - это квадрат числа a");
    return;
}
if(b * b == a) {
    Console.WriteLine("a - квадрат числа b");
}
else {
    Console.WriteLine("Ни одно число не является квадратом!");
}