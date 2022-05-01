Console.WriteLine("Для уравнения y=k1*x+b1 введите значения:");
Console.Write("b1=");
double b1 = double.Parse(Console.ReadLine());
Console.Write("k1=");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Для уравнения y=k2*x+b2 введите значения:");
Console.Write("b2=");
double b2 = double.Parse(Console.ReadLine());
Console.Write("k2=");
double k2 = double.Parse(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine($"k1=k2 -> {k1}={k2}; b1=b2 -> {b1}={b2} -> прямые совпадают");
}
else
{
    if (k1 == k2)
    {
        Console.WriteLine($"k1=k2 -> {k1}={k2} -> прямые параллельны и не имеют точек пересечения");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);//
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых имеют координаты х={x}; y={y}");
    }
}