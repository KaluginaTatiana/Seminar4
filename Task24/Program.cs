// Принимает на вход число N и выдает на выходе сумму чисел от 1 до N
Console.WriteLine("Ведите целое положительное число.");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n % 1 ==0)
{
    Console.WriteLine("Сумма чисел от 1 до " + n + " равна " + FindSum(n));
}
else
{
    Console.WriteLine("Ошибка ввода. Введите целое положительное число.");
}

int FindSum(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}



