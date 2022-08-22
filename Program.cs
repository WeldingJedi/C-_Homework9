void Task64()
{
    // Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
    // M = 1; N = 9. -> "3, 6, 9"
    // M = 13; N = 20. -> "15, 18"

    Random random = new Random();
    int m = random.Next(1, 11);
    Console.WriteLine($"Number m: {m}");
    int n = random.Next(10, 35);
    Console.WriteLine($"Number n: {n}");
    if (m < n) Console.WriteLine($"Multiples of three numbers from {m} to {n}: ");
    if (m == n && m % 3 == 0) Console.WriteLine($"That's only: ");
    if (m == n && m % 3 != 0) Console.WriteLine($"Sorry, that number doesn't fit conditions of the task");
    MultipliesOfThreeIntegers(m, n);
}

void Task66()
{
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8. -> 30

    Random random = new Random();
    int m = random.Next(1, 21);
    Console.WriteLine($"Number m: {m}");
    int n = random.Next(1, 21);
    Console.WriteLine($"Number n: {n}");
    IntervalSumOfIntegers(m, n);
    if (m < n) Console.WriteLine($"Interval sum from {m} including to {n} including: {IntervalSumOfIntegers(m, n)}");
    if (m > n) Console.WriteLine($"Interval sum from {n} including to {m} including: {IntervalSumOfIntegers(m, n)}");
    if (m == n) Console.WriteLine($"Ha! It's just a: {IntervalSumOfIntegers(m, n)}");
}

void Task68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9

    Random random = new Random();
    int m = random.Next(1, 4);
    Console.WriteLine($"Number m: {m}");
    int n = random.Next(1, 4);
    Console.WriteLine($"Number m: {n}");
    Ackermann(m, n);
    Console.WriteLine($"Ackermann function: {Ackermann(m, n)}");
}

int MultipliesOfThreeIntegers(int m, int n)
{
    while (m < n + 1)
    {
        if (m % 3 == 0) 
        {
            Console.Write($"{m} ");
            return MultipliesOfThreeIntegers(m + 3, n);
        }
        else m++;
        return MultipliesOfThreeIntegers(m, n);
    }
    return m - 3;
}

int IntervalSumOfIntegers(int m, int n)
{
    if (n > m) return n + IntervalSumOfIntegers(m, n - 1);
    if (n < m) return m + IntervalSumOfIntegers(n, m - 1);
    return n;
}

double Ackermann(double m, double n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m, n);
}

//Task64();
//Task66();
//Task68();