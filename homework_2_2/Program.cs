Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string str = Convert.ToString(N);
    Console.WriteLine("Третья цифра числа: " + str[2]);
}