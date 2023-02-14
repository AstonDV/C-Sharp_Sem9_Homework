// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if (m != 0 && n == 0) return Ackermann(m - 1, 1);
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}


void PrintResult(int firstNum, int secondNum)
{
    Console.WriteLine($"A({firstNum}, {secondNum}) = {Ackermann(firstNum, secondNum)}");
}

void Main()
{
    Console.Clear();
    int firstNumber = Input("Введите первое положительное целое число");
    int secondNumber = Input("Введите второе положительное целое число");
    PrintResult(firstNumber, secondNumber);
}

Main();