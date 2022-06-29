Console.WriteLine("Введите высоту шеста (м): ");
int pole_height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту подъема улитки за день по шесту (м): ");
int way_up = Convert.ToInt32(Console.ReadLine());
int way_down, day = 0;
do
{
    Console.WriteLine("Введите высоту спуска улитки за ночь по шесту из условия, что высота подъема должна быть больше (м): ");
    way_down = Convert.ToInt32(Console.ReadLine());
}
while (way_up <= way_down);
while (pole_height > (day * (way_up - way_down) + way_up)) day++;
Console.WriteLine("Улитка доползет до вершины шеста на " + (day + 1) + " день.");