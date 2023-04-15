// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int x1 = Coordinate("X", "A");
int y1 = Coordinate("Y", "A");
int z1 = Coordinate("Z", "A");
int x2 = Coordinate("X", "B");
int y2 = Coordinate("Y", "B");
int z2 = Coordinate("Z", "B");

int Coordinate(string CoordinateName, string PointName)
{
    Console.Write($"Введите координату по оси {CoordinateName} точки {PointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка составит {segmentLength}");