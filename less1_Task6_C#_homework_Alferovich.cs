Console.WriteLine("Пожалуйста, введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Это чётное число.");
}
else
{
    Console.WriteLine("Это нечётное число.");
}