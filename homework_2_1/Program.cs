Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a % 100;
int c = b / 10;
Console.WriteLine("Вторая цифра введенного числа: " + c);
