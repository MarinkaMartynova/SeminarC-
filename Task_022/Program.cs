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