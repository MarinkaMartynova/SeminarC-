/* Задача 2: Напишите программу, которая на вход принимает два числа и 
выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
// Решение, где мы прописываем оба числа, максимальное и минимальное
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b) {
    Console.WriteLine(a +  " большее число");
    Console.WriteLine(b +  " меньшее число");
}
if(a < b) {
    Console.WriteLine(b +  " большее число");
    Console.WriteLine(a +  " меньшее число");
}


/* Вариант решения, где нужно просто максимальное найти и прописать его
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b) {
    Console.WriteLine(a);
}
if(a < b) {
    Console.WriteLine(b);
}
*/