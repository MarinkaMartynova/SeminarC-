//"Это документ шпаргалка по методам C#"

//Console.WriteLine("Введите данные");    

// Метод Console.WriteLine - Записывает указанные данные 
// с текущим признаком конца строки
// в стандартный выходной поток. 

/*
Console.WriteLine(“Hello, World!”);
Console.WriteLine(“=Second Line=”);

Результатом вывода будет две строки.

    Hello, World!
    =Second Line=
*/    

//Console. Консоль (Console) - характерная особенность ранних операционных систем (например, MS DOS), 
//использующих интерфейс командной строки  для интерактивного обмена информацией с пользователем. 
//WriteLine

/*
Console.Write("Введите ваше имя ");       // Вывод сообщения без перехода на новую строку

string username = Console.ReadLine();    // метод для ввода строки символов типа стринг. 
                                         //Дословно берем переменную userename и присваиваем ее символам 
                                         //строковый тип == текст
*/


//int numberA = new Random().Next(1, 10); // 1,2,3,4...9     //команда присваивания случайного числа в диапазоне
                                                           //берем целую переменную и присваиваем ей случайное значение 
                                                           //в диапазоне от 1 до 10
//Console.WriteLine(numberA);                                // выводим сообщение


/*
if(username.ToLower() == "маша")                   // если переменная типа стока имеет значение маша 
                                                   //(ToLower = переводит все символы в регистр нижнего подчеркивания)
{
    Console.WriteLine("Ура,это же МАША!");         // то выводим сообщение
}
*/

/*
Console.Clear();                   //метод очищения консоли. Удаляет из буфера консоли  
                                   //и ее окна отображаемую информацию.
*/
/*
Console.SetCursorPosition(10, 4);               //метод, указывает, где начинается следующая операция записи в окне консоли.
Console.WriteLine("+");                     //при выводе сообщения будет прописываться символ +
count = count + 1; //или count++;             //чтобы число не ушло в бесконечность
*/

//Теперь воспользуемся функциями:
/*
int Max(int arg1, int arg2, int arg3)   // Берем в качестве максимального числа некоторые аргументы 1 ,2 ,3
{                                        //Опишем тело метода
    int result = arg1;                    //определяем внутренний резалт, где будет хранится значение максимального
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;                        //метод возвращает резалт.т.о. появляется вспом. механизм, который ищет максимальное среди 3 чисел
}                 /*этот кусочек кода отвечает за поиск максимума из 3х 
                     (если возникает ошибка, не надо бегать по всему 
                     коду мы правим этот кусочек)*/
/*
int a1 = 15111222;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 232;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

// int max1 = Max(a1, b1, c1);               //создадим переменную макс1. Результатом работы функции Max будет являтся максимальное среди 3х чисел
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);


int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));  //Верхние 4 строчки можно заменить одной строкой

Console.WriteLine(max);                  //Когда предыдущий кусочек отработает, мы на выходе получим максимальное из 3х чисел == 39

//Это самое простое введение в функции


int Max(int arg1, int arg2, int arg3)   // Берем в качестве максимального числа некоторые аргументы 1 ,2 ,3
{                                        //Опишем тело метода
    int result = arg1;                    //определяем внутренний резалт, где будет хранится значение максимального
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;                        //метод возвращает резалт.т.о. появляется вспом. механизм, который ищет максимальное среди 3 чисел
}

//Убрали переменные и добавим теперь  массив
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 21, 31, 41, 15, 61, 17, 18, 19 }; //Так прописывается массив
//array [0] = 12;                       //эта строчка показывает -Как можно обратится к массиву и записать в него значение
//Console.WriteLine(array[4]);     //здесь показано как можно обратится к массиву ти получить значение соответствующее элементу массива

//!внимание не количество определяем, а индекс 0,1,2,3,-8
//Как теперь искать максимум?
int max = Max(                                //Внимание Функция - Max / переменная - max
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);


/* Задача поиска позиции нужного нам элемента
Допустим Имеется новый массив array из n элементов,
требуется найти элемент массива, совпадающий с некоторым значением , которое может определять пользователей. 
Сохраним его в переменную find.
- Далее мы установим счетчик в нулевую позицию. index в позицию 0
-Если  array [index] = find - алгоритм завершит работу успешно.// Если в текущем состоянии совпал с файндом то мы нашли нужное значение
- увеличить index на 1       //если не совпал то мы увеличим значение счетчика на 1
- если index < n, то перейти к шагу 2.  // и перейдем к предыдущему шагу. если array совпал с find завершаем работу
В противном случае завершить работу безуспешно.*/
/*
int[] array = { 1, 12, 31, 18, 4, 15, 16, 17, 18 };   //если одинаковых значений будет несколько, то их всех покажет на выходе
int find = 18;

int index = 0;
while (index < find)
{

    if (array[index] == find)
    {
        Console.WriteLine( index);
        break;                        // позволит исправить результат, если будет 2 одинаковых значения
        
    }
    //index = index +1
    index++;
}


void FillArray (int[] collection)   //метод, который ничего не возвращает. это войд и в коде не используем поэтому оператор return
{
    int length = collection.Length;   //получим длину массива
    int index = 0;                   //Возьмем позицию индекс , которая будет начинаться с нуля
    while (index < length)            //пока индекс < длины то
    {
        collection[index] = new Random().Next(1, 10);   //обратится к аргументу коллекция и положить туда целое число от 1 до 10
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;         //искусственный элемент когда значения не существует
                               //( потому что по умолчанию пр инеправильном элементе выдает 0)
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10];    //новая конструкция: создай новый массив в котором будет 10 элементов (дословно)
                                 //по умолчанию заполнен нулями
FillArray(array);                 //заполнили массив набором чисел
array[4] = 4;
array[6] = 4;
PrintArray(array);                //и распечатали набор чисел
Console.WriteLine();

int pos = IndexOf(array, 44);      //если введем позицию которой не существует? тогда int position = -1; 
                                   //(придумка программистов) говорит о том что элемент не найден
Console.WriteLine(pos);


// See https://aka.ms/new-console-template for more information

//Задача 0
/*Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n*n);
*/


//Задача 1
/* Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());  
              //Означает, что вы вводите в консоли в данном месте число, 
              //но оно считывается как строка, конечно же. 
              //и ToInt32 преобразует это строковое число в 
              //обычный int32 (32 битное целое число)
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b*b)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет");    
}
*/


//Задача 3
//1 вариант задачи с while
/* Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int weekDay = Convert.ToInt32(Console.ReadLine());
while (weekDay < 1 | weekDay > 7) {
    Console.WriteLine("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if(weekDay == 1) Console.WriteLine("Понедельник");
else if(weekDay == 2) Console.WriteLine("Вторник");
else if(weekDay == 3) Console.WriteLine("Среда");
else if(weekDay == 4) Console.WriteLine("Четверг");
else if(weekDay == 5) Console.WriteLine("Пятница");
else if(weekDay == 6) Console.WriteLine("Суббота");
else if(weekDay == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Вы ввели недопустимый номер дня недели");
*/

//2 вариант с switch
/*Console.Write("Введите номер дня недели (от 1 до 7): ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 | a > 7) {
    Console.Write("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");
    a = Convert.ToInt32(Console.ReadLine());
}
switch(a) {
    case 1: Console.WriteLine("Понедельник");
    break;
    case 2: Console.WriteLine("Вторник");
    break;
    case 3: Console.WriteLine("Среда");
    break;
    case 4: Console.WriteLine("Четверг");
    break;
    case 5: Console.WriteLine("Пятница");
    break;
    case 6: Console.WriteLine("Суббота");
    break;
    case 7: Console.WriteLine("Воскресенье");
    break;
          default: Console.WriteLine("Вы ввели недопустимый номер дня недели");
          break;
}
*/

//Задача 5
// 1 вариант решения
/* Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int i = n*(-1);
while (i <= n) {
    Console.Write (Convert.ToString(i) + " ");
    i++;
}
*/

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

//Задача 7
/*Console.Write("Введите трехзначное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 100| n > 999) {
    Console.Write("Вы ввели недопустимое число, повторите ввод: ");
        n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Последняя цифры числа: "+Convert.ToString (n%10));
*/

// 2 вариант 


/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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


/* Задача 4: Напишите программу, которая принимает на вход три числа и 
выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/ 
/*
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


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */
/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0){
    Console.WriteLine("да");
}
else Console.WriteLine("нет");


/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
/*
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int even = 2;                                    //even - "четный"
while (n >= even){
    Console.Write( even + ", ");
    even += 2;
}
*/

/*  задача 009 Напишите программу, которая выводит случайное число из отрезка (10,99) и показывает наибольшую цифру числа
78 - 8
12 -2
85- 8
*/

/* 1 var
int n = 0;
n = new Random().Next(10,99);  // метод для выборки случайных чисел. 
//new - новый объект рандома и передаем с помощью нексту в диапазоне, где нужно находить число
Console.WriteLine (n);     //для запуска
int first = n/10;           //первое число мы получим если поделим на 10
int second = n%10;          // вторая цифра числа находится делением на остаток
Console.WriteLine(first);    //выводим на экран 1 число
Console.WriteLine(second);    //выводим на экран 2 число
*/
/*
// Задание 009
int a = new Random().Next(10,99);
    Console.WriteLine(a);
int first = a / 10;
int second = a %10;
if (first > second)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(second);
}

*/


/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int ThreeDigitNumber = new Random().Next(100, 1000);  //берем случайное число трехзначное
int secondDigit = ThreeDigitNumber / 10 % 10;                   //делим 3-зн число на 10 и делим на  остаток от деления на 10 и получаем 2 число
Console.WriteLine(ThreeDigitNumber);                  //выводим результат : само 3-зн число
Console.Write( secondDigit );                    //вторая цифра числа
 
 */

/* задача 11 Напишите программу, которая выводит случайное 
трехзначное число и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/
/*
int n = new Random().Next(100, 1000);  //берем случайное число трехзначное
int a = n / 100%10;                        //целому числу а присваиваем значение равное первому значению трехначного числа
int b = n % 10;                        //числу б присваиваем значение остатка от деления на 10 

Console.WriteLine(n);                  //выводим на экран трехзначное число
Console.Write( a );                     //выводим первое значение
Console.Write( b );                     // выводим последнюю цифру

// Console.WriteLine(a + " " + b);    // еще один вариант последних трех записей
*/

/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли первое число кратным второму. Если число 1 не кратно числу 2,
 то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

/*
Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

if (first  % 2 == second % 2) 
{
   Console.WriteLine("Кратно!"); 
}

else 
{
    Console.WriteLine("Не является кратным; Остаток " + first % second);
}
*/


/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine("В числе нет третьей цифры");
}

else 
{
    while(num > 999) {
        num = num / 10;
        }
    Console.WriteLine(num % 10);
}
*/

/*14. Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0) {     //остаток от деления  = 0, 
                                        //т.е. число делится без остатка
    Console.WriteLine("Число кратно 7 и 23"); 
}
else {
    Console.WriteLine("не кратно 7 и 23");
}
*/

/*
Console.WriteLine("Введите число ");             //2 вариант (учителя)
int n = Convert.ToInt32(Console.ReadLine());

bool ismultiplicity(int a) {                  // проверка true or false
    return (a % 7 == 0 & a % 23 == 0);
}
if (ismultiplicity(n)) {
    Console.WriteLine("Делится!");
}

else {
    Console.WriteLine("Не делится!");
}
*/



/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
Console.Write("Напиши порядковый номер дня недели (1-7): ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

while(dayWeek < 1 | dayWeek > 7) {
    Console.WriteLine("В какой вселенной это день недели? Четенько 1-7: ");
    dayWeek = Convert.ToInt32(Console.ReadLine());
}

if (dayWeek == 1) {
    Console.WriteLine ("Понедельник - иди работай!");
}
else if (dayWeek == 2) {
    Console.WriteLine ("Вторник - работа все еще ждет!");
}
else if (dayWeek == 3) {
    Console.WriteLine ("Среда - и это не выходной!");
}
else if (dayWeek == 4) {
    Console.WriteLine ("Четверг - нет не выходной!");
}
else if (dayWeek == 5) {
    Console.WriteLine ("Пятница - почти, но не выходной!");
}
else if (dayWeek == 6) {
    Console.WriteLine ("Суббота - Ура выходной!");
}
else if (dayWeek == 7) {
    Console.WriteLine ("Воскресенье - Ура выходной!");
}
*/

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

/*
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
*/

/* 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдает номер четверит плоскости, 
в которой находится эта точка
*/
/*
Console.Write("Введите x: ");
int x = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) {
    Console.WriteLine("Первая четверть");
}
if (x > 0 && y < 0) {
    Console.WriteLine("Вторая четверть");
}
if (x < 0 && y > 0) {
    Console.WriteLine("Третья четверть");
}
if (x < 0 && y < 0) {
    Console.WriteLine("Четвертая четверть");
}
*/

/* 18/Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (х и у).
*/

/*
Console.Write("Укажите номер четверти 1-4: ");
int quadrant = Convert.ToInt32(Console.ReadLine());
while(quadrant < 1 | quadrant > 4) {
    Console.Write("Неверное значение. Повторите ввод: ");
    quadrant = Convert.ToInt32(Console.ReadLine());
}
if (quadrant == 1) {
    Console.WriteLine("x > 0 , y > 0");
}
if (quadrant == 2) {
    Console.WriteLine("x < 0 , y > 0");
}
if (quadrant == 3) {
    Console.WriteLine("x > 0 , y < 0");
}
if (quadrant == 4) {
    Console.WriteLine("x < 0 , y < 0");
}
*/
/*
// вариант учителя
Console.Write("Укажите номер четверти 1-4: ");
int quadrant = Convert.ToInt32(Console.ReadLine());

switch (quadrant){
    case 1: {
        Console.WriteLine("x > 0 , y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("x > 0 , y < 0");
        break;
    }
    case 3: {
        Console.WriteLine("x < 0 , y > 0");
        break;
    }
    case 4: {
        Console.WriteLine("x < 0 , y < 0");
        break;
    }
    default: {
        Console.WriteLine("Введена неправильная четверть");
        break;
    }
}
*/


/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
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
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
Console.Write("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = 0;
distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
Console.WriteLine("Расстояние между точками равно: " + Math.Round(distance, 2));

/* Напишите программу, которая принимает на вход координаты двух точек
и нахоидт расстояние между ними в 2D пространстве
 //теорема Пифагора c^2 = a^2 + b^2
 //таким образом c = квадртаному корню(a^2 + b^2)
 */
/*
Console.Write("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
double distance = 0;
distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
Console.WriteLine("Расстояние между точками равно: " + Math.Round(distance, 2));
*/

/* 22. Напишите программу, которая принимает на вход число (N)
и выдает таблицу квадратов чисел от 1 до N
5 -> 1,4,9,16,25
2 -> 1,4
*/
/*
Console.Write("Enter the number of: ");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= num; i++) {
    Console.Write(i * i + ", ");
}
*/
/*
// решение в классе
bool terms = true;
while(terms) {
    try {
        Console.Write("Enter the number of: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int index = 0;
        for(int i = 1; i <= num; i++) {
            index = (int)Math.Pow(i, 2);
            if(i ==num)
            Console.Write(index + ". ");
            else {
                Console.Write(index + ", ");
            }
        }
        terms = false;
    }
    catch {
        Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
    }
}
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
Console.Write("Enter the number of: ");
            int N = int.Parse(Console.ReadLine()); 
            for(int i = 1; i <= N; i++)
                Console.Write(i*i*i +", ");
 
            Console.ReadLine();*/
