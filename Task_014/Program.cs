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

/**/
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
/**/
