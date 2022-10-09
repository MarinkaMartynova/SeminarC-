/* Напишите программу, которая принимает на вход координаты двух точек
и нахоидт расстояние между ними в 2D пространстве

 //теорема Пифагора c^2 = a^2 + b^2
 //таким образом c = квадртаному корню(a^2 + b^2)
 */

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