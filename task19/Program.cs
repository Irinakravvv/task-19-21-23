//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double EuclideanDistance();
{
Console.WriteLine("Введите координаты точки A ");
Console.Write("x:  ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("y:  ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("z:  ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
Console.Write("x:  ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("y:  ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("z:  ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xB-xA, 2) + Math.Pow(yB-yA, 2) + (Math.Pow(zA-zA, 2)));

double resalt =  distance;
}


Console.WriteLine("Расстояние между точками = " + Math.Round(EuclideanDistance(), 2));