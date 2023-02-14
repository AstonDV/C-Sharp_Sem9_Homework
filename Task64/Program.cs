// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int LineOfNumbers (int n)
{
    if (n == 1) return n;
    else
    {
        Console.Write($"{n}, ");
        return n = LineOfNumbers(n-1);
    }
}

void Main()
{
    Console.Clear();
    int number = Input("Введите ваше число");
    Console.WriteLine();
    Console.WriteLine(LineOfNumbers (number));
}

Main();