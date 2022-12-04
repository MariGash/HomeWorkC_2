Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N % 7 == 0)
{
    if(N % 23 == 0)
    {
        Console.Write(N + " кратно одновременно 7 и 23");
    }    
    else
    {
        Console.Write(N + " некратно одновременно 7 и 23");
    }
}
else
{
    Console.Write(N + " некратно одновременно 7 и 23");
}