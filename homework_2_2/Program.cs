Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(N > 1000)
    {
        N = N / 10;
    }
    Console.WriteLine("Третья цифра числа: " + N % 10);
}
