// Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
// Правильная скобочная последовательность - символьная последовательность, 
// составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
// Пример правильной скобочной последовательности: (), ()[]{}
// Пример неправильной: (], ({)}
// Написать программу, которая определяет правильная ли скобочная последовательность была введена


string Input(string text)
{
    Console.Write($"{text}: ");
    string value = Console.ReadLine()!;
    return value;
}

bool SearchPairsOfBrackets(string brackets) 
{ 
    Stack<char> stack = new(); 
    for (int i = 0; i < brackets.Length; i++) 
    { 
        char c = brackets[i]; 
        if (c == ']') 
        { 
            if (stack.Count == 0 || stack.Pop() != '[') 
            return false; 
        } 
        else if (c == ')') 
        { 
            if (stack.Count == 0 || stack.Pop() != '(') 
            return false; 
        } 
        else if (c == '}') 
        { 
            if (stack.Count == 0 || stack.Pop() != '{') 
            return false; 
        } 
        else stack.Push(c); 
    } 
    return stack.Count == 0; 
}

void PrintResult(string brackets)
{
    if (SearchPairsOfBrackets(brackets))
    Console.WriteLine("Введенная скобочная последовательность верна!!!");
    else
    Console.WriteLine("Введенная скобочная последовательность неверна");
}

void Main()
{
    Console.Clear();
    string inputBrackets = Input("Введите скобочную последовательность");
    Console.WriteLine();
    PrintResult(inputBrackets);
}

Main();