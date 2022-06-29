Console.WriteLine("Введите номер дня недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if((userNumber%6 == 0) || (userNumber%7 == 0)) Console.WriteLine(userNumber + "-й день недели выходной!");
else Console.WriteLine(userNumber + "-й день недели НЕ выходной!");