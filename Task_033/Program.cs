/* Задача 33: 
Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6,7,19,345,3] -> нет
-3; массив [6,7,19,345,3] -> да
*/


//мой вариант
///*
int[] array = new int[5];
bool exist = false;

Console.Write("Какое число проверить?:  ");
int n = Convert.ToInt32(Console.ReadLine()); 

for(int i = 0; i < array.Length; i++) {
    
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + ", ");
}
Console.WriteLine();

for(int i = 0; i < array.Length; i++) {
    
    if(n == array[i]) {
        exist = true;
    }
}
if(exist == true){
    Console.Write("Значение присутствует в массиве");
}
else {
    Console.Write("Значение отсутствует в массиве");
}
//*/

//пример с семинара
/*
int[] array = new Int32[10];
bool exist = false;
newArray(array);
PrintArray(array);

void newArray(int[] array, min, max) {
for(int i = 0; i < array.Length; i++) {
    
    Console.Write("Введите значение массива: ");
    int a = Convert.ToInt32(Console.ReadLine()); 
    array[i] = a;
    //array[i] = new Random().Next(0,10);
    //Console.Write(array[i] + ", ");
}
}
void PrintArray(int[] array){
    for ( int i = 0; i < array.Length; i++) {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}, ");

}
Console.WriteLine();*/



/*
newArray(array);
PrintArray(array);

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

string result = Poisk(array, number)? $"Число {number} входит в массив" : $"Число {number} не входит в массив";
Console.WriteLine(result);

bool Poisk(int[]array, int n) {
    bool h = false;
    for (int i = 0; i < array.Length; i++) {
        if(array[i] == n) {
            h = true;
            break;
        }
    }
    return h;
}
*/