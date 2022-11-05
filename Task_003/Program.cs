/* Задача 3:
Напишите программу, которая будет выдавать название 
дня недели по заданному номеру.
3 -> max = Среда
5 -> max = Пятница
*/


//1 вариант задачи с while
 Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
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