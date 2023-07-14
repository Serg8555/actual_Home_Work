// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


    Console.WriteLine("for Ackerman function please put number m, then n");
    int m = GetNumber("need number m:");
    int n = GetNumber("need number n:");

    if (n >= 0 && m >= 0)
    {
        int result = CalculateAckerman(m, n);
        if (result != -1)
            Console.WriteLine($"Result: {result}");
        else
            Console.WriteLine($"РResult for m = {m} and n = {n} is too big");
    }
    else
    {
        Console.WriteLine("please put positive numbers");
    }

    Console.ReadLine();

static int GetNumber(string description)
{
    int number;
    Console.Write($"{description} => ");
    while (true)
    {
        string? temp = Console.ReadLine();
        if (int.TryParse(temp, out number))
        {
            return number;
        }
        Console.Write($"the number {temp} is not correct");
    }
}

static int CalculateAckerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return CalculateAckerman(m - 1, 1);
    else if (m == 1)
        return n + 2;
    else if (m == 2)
        return 2 * n + 3;
    else if (m == 3)
        return (int)Math.Pow(2, n + 3) - 3;
    else if (m == 4)
    {
        if (n <= 1)
            return (int)Math.Pow(2, Math.Pow(2, n + 3)) - 3;
        else
            return -1; // (the number is too big)
    }
    else
        return -1; // (the number is too big)
}

