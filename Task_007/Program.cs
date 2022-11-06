/*Задача 7: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

///*
Console.Write("Введите трехзначное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 100| n > 999) {
    Console.Write("Вы ввели недопустимое число, повторите ввод: ");
        n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Последняя цифры числа: "+Convert.ToString (n%10));
//*/
