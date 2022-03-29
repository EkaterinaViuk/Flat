// See https://aka.ms/new-console-template for more information
Console.Write("Номер квартиры: ");
double flat; 
double.TryParse(Console.ReadLine(), out flat);
Console.Write("Сколько этажей в подъезде: ");
double floor;
double.TryParse(Console.ReadLine(), out floor);
Console.Write("Сколько квартир на этаже: ");
double num;
double.TryParse(Console.ReadLine(), out num);
double ost = Math.Ceiling(flat/(num*floor)) - floor*num;
double r = Math.Ceiling((flat - Math.Ceiling(flat / (floor * num)) * floor * num * ost) / num);
Console.WriteLine($"Квартира находится в {Math.Ceiling(flat/(floor*num))} подъезде на {r} этаже");
Console.WriteLine("Hello,World!");
