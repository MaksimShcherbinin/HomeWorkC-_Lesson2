Console.WriteLine("Введите расстояние между рядами (мм): "); //a
int row_spacing = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите расстояние между дырочками в ряду (мм): "); //b
int distance_holes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину свободного конца шнурка (мм): "); //l
int free_end_length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество дырочек в каждом ряду (шт): "); //N
int number_of_holes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Длинна шнурка составит " + (row_spacing + (number_of_holes - 1) * 2 * (distance_holes + row_spacing) + 2 * free_end_length) + " мм.");