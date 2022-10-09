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
