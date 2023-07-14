// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int GetNumber(string description){
    int number;
    Console.Write($"{description} => ");
    while(true){
        string? temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"The number {temp} is not correct");
    }
}

string ReturnNaturalNumbers(int number){
    if(number == 1) return number.ToString();
    return number + ", " + ReturnNaturalNumbers(number-1);
}
Console.Clear();

int n = GetNumber("To get all natural numbers");
if (n >= 0) Console.WriteLine($"{n} ->  {ReturnNaturalNumbers(n)}");
else Console.WriteLine($"Number {n} is not positive ");