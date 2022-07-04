/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.WriteLine("Введите координаты точки А");
int Xa = Convert.ToInt32(Console.ReadLine());
int Ya = Convert.ToInt32(Console.ReadLine());
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
int Xb = Convert.ToInt32(Console.ReadLine());
int Yb = Convert.ToInt32(Console.ReadLine());
int Zb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(Xa - Xb , 2) + Math.Pow(Ya - Yb , 2) + Math.Pow(Za - Zb , 2)));