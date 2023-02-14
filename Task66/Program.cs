// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int SummOfNumbers(int m, int n)
{
    if (m < n)
    {
        if (m == n) return n;
        else
        {
            return n + SummOfNumbers(m, n - 1);
        }
    }
    else
    {
        if (n == m) return m;
        else
        {
            return m + SummOfNumbers(n, m - 1);
        }
    }
}

void PrintResult(int firstNum, int secondNum)
{
    Console.Write($"Сумма натуральных чисел в введенном промежутке равна {SummOfNumbers(firstNum, secondNum)}");
}

void Main()
{
    Console.Clear();
    int firstNumber = Input("Введите первое число");
    int secondNumber = Input("Введите первое число");
    PrintResult(firstNumber, secondNumber);
}

Main();