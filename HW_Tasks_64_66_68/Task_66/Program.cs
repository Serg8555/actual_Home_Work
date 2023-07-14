// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


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

int GetIntervalSum(int m, int n){
    if(m == n) return n; 
        return m + GetIntervalSum(m+1, n);
}
Console.Clear();

int m = GetNumber("Sum of the numbers from M to N, put thenumber M ");
int n = GetNumber("put the number N ");
if(m > n){
    int temp = m;
    m = n;
    n = temp;
} 
Console.WriteLine(GetIntervalSum(m, n));