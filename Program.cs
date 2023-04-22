/*

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

Console.WriteLine ( "Введите Х координату точки А" );

int xa = int.Parse (Console.ReadLine());

Console.WriteLine ( "Введите Y координату точки А" );

int ya = int.Parse (Console.ReadLine());

Console.WriteLine ( "Введите Z координату точки А" );

int za = int.Parse (Console.ReadLine());


Console.WriteLine ( "Введите Х координату точки B" );

int xb = int.Parse (Console.ReadLine());

Console.WriteLine ( "Введите Y координату точки B" );

int yb = int.Parse (Console.ReadLine());

Console.WriteLine ( "Введите Z координату точки B" );

int zb = int.Parse (Console.ReadLine());


double resultPowX = Math.Pow(xb - xa, 2);
Console.WriteLine (resultPowX);

double resultPowY = Math.Pow(yb - ya, 2);
Console.WriteLine (resultPowY);

double resultPowZ = Math.Pow(zb - za, 2);
Console.WriteLine (resultPowZ);


double result = Math.Sqrt(resultPowX + resultPowY + resultPowZ);
Console.WriteLine (result);

return;