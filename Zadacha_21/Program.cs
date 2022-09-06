// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

string Coordinates()
{
    Console.Write("Введите координату X для первой точки ");
    int ax = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите координату Y для первой точки ");
    int ay = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите координату Z для первой точки ");
    int az = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите координату X для второй точки ");
    int bx = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите координату Y для второй точки ");
    int by = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Введите координату Z для второй точки ");
    int bz = Convert.ToInt32(Console.ReadLine());
    
    double c = 0;
    c = Math.Sqrt((Math.Pow((bx-ax), 2)) + (Math.Pow((by- ay), 2)) + (Math.Pow((bz-az), 2)));
    
    return $"Расстояние между двумя точками {c}";    
}

try
{
    Console.WriteLine(Coordinates());
}
catch
{
    Console.WriteLine("Вводите координаты цифрами");
}