// Расстояние между точками в 3D пространстве.
Console.WriteLine("Введите координату Х первой точки");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату У первой точки");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
int z2 = int.Parse(Console.ReadLine());


double skalyar = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
System.Console.WriteLine(skalyar);
