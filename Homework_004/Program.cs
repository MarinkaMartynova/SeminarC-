/* Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/ 
//
Console.Write("Загадай число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Еще одно число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("И еще одно: ");
int c = Convert.ToInt32(Console.ReadLine());
if(a > b) {
    if(a > c) {
        Console.WriteLine(a);        
    }
    else Console.WriteLine(c);
}
if(a < b) {
    if(b > c) {
        Console.WriteLine(b);        
    }
    else Console.WriteLine(c);
}