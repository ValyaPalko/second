// See https://aka.ms/new-console-template for more information
Console.Write("Введите координаты точки X и Y через пробел: ");
String[]coordinates = Console.ReadLine().Split(" ");
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
if (x > 0 && y > 0) 
{
    Console.WriteLine("1");
}
else if (x < 0 && y > 0)
{ 
    Console.WriteLine("2"); 
}
else if (x < 0 && y < 0)
{ 
    Console.WriteLine("3"); 
}
else if (x > 0 && y < 0)
{ 
    Console.WriteLine("4"); 
}
else if (x == 0)
{
    Console.WriteLine("Точка находится на оси Y"); 
}
else if (y == 0)
{
    Console.WriteLine("Точка находится на оси X"); 
}

