/*Задача 5: Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4 -3 -2 -1 0 1 2 3 4"
2 -> "-2 -1 0 1 2"
*/


// 1 вариант решения
///* 
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int i = n*(-1);
while (i <= n) {
    Console.Write (Convert.ToString(i) + " ");
    i++;
}
//*/

// 2 вариант задачи -(программа выводит все четные числа)
/* Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());  //получили число (4)
int max = n;  //мы получили ввод пользователя -это верхняя граница. (4 будет максимальным)
while (-n <= max){           //пока  -4 <= 4 первый проход цикла
    //if(n % 2 == 0){
        Console.Write (-n + " ");  //если условие выполняется мы попадаем в тело while
        n--;                        // 
   // }
   // else {
   //     Console.Write (-n + " ");
   //     n--;
   // }
}
*/

// 3 вариант задачи через for
/* int n = 0;
Console.WriteLine("Введите число N");
n = Convert.ToInt32(Console.ReadLine());
for (int i = -n; i <= n; i++) {           //
    Console.Write (i + " ");  //
}                   
*/
