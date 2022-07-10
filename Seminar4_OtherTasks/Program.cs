// Все остальные задачи семинара

void Task26() // На вход подается целое число, нужно вывести количество цифр в числе
{
    Console.WriteLine("Введите целое число");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Разрядность числа {n} равна {Razryadnost(n)}");

    int Razryadnost(int number)
    {
        int razr = 1;
        while (number / 10 != 0)
        {
            razr++;
            number = number / 10;
        }
        return razr;
    }
}
//Task26();

void Task28() //На вход подается число N, на выходе должно быть произведение чисел от 1 до N
{
    Console.WriteLine("Введите целое число");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Произведение чисел от 1 до {n} равно {Factorial(n)}");

    int Factorial(int number)
    {
        int m = 1;
        for (int i = 1; i <= number; i++)
        {
            m = m * i;
        }
        return m;
    }
}
//Task28();

void Task30_1()  // Программа, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке
{
    int size = 8;
    int[] array1 = new int[size];
    void PrintArrayRandom(int[] array)
    {
        for (int i = 0; i < 8; i++)
        {
            array[i] = new Random().Next(0, 2);
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
    PrintArrayRandom(array1);
}

Task30_1();

