Console.WriteLine("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

while (userNumber > 99) userNumber = (userNumber - userNumber % 10) / 10;

Console.WriteLine("Вторая цифра введенного числа: " + userNumber%10);