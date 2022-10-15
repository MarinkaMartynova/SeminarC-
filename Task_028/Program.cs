/* Задача 28: Напишите программу, которая принимает на вход число N
 и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/ 
///*
Console.WriteLine("Enter the number of:  ");
int N = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= N; i++ )
{
    factorial = factorial * i;
}
Console.WriteLine(factorial);
//*/

//2вариант^ дает сразу 2 произедения на число и число +1
/*
int num = int.Parse(Console.ReadLine());

int result = addition(num);

Console.WriteLine(result);


int x = addition(num + 1);

Console.WriteLine(x);

int addition(int number)
{
    int count = 1;
    
    for (int i = 1; i <= number; i++)
    {
        count = count * i; // count *= i;
    }

    return count;
}
*/