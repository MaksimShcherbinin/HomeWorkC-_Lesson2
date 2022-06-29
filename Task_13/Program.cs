Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber < 100) Console.WriteLine("Третьей цифры числа " + userNumber + " нет!");
else
{
   while (userNumber > 999) userNumber = (userNumber - userNumber % 10) / 10;
   Console.WriteLine("Третья цифра введенного числа: " + userNumber%10); 
}