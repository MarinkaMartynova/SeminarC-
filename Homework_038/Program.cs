/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/

//Можно ли оставить решение для дробных чисел? Меня как то переклинило, пока читала задание
/*
Console.WriteLine("Исходный массив: ");

double[] array = new double[5];
Random random = new Random();

for (int i = 0; i < array.Length; i++) {    
    array[i] = random.NextDouble() * 100;
    Console.WriteLine(array[i].ToString("F1"));
}
Console.ReadKey();
*/

double[] array = new double[5];
Random random = new Random();
Console.Write("Исходный массив: ");
for (int i = 0; i < array.Length; i++ ){
      array[i] = Math.Round(random.NextDouble() * 100, 2);
      Console.Write(array[i] + " ");
}

double maxNumber = array[0];
double minNumber = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (maxNumber < array[i]){
        maxNumber = array[i];
    }
    if (minNumber > array[i]){
        minNumber = array[i];
    }
}

double  diff = maxNumber - minNumber;

Console.WriteLine();
Console.WriteLine("максимальный элемент: " +  maxNumber);
Console.WriteLine("Минимальный элемент:  " + minNumber);
Console.WriteLine("Hазница между максимальным и минимальным элементами: " + Math.Round(diff, 2));
