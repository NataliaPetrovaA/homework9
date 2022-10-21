// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermanFunction(int NumberM, int NumberN)
{
    if (NumberM == 0) return NumberN + 1;
    if (NumberM != 0 && NumberN == 0) return AckermanFunction(NumberM - 1, 1);
    if (NumberM > 0 && NumberN > 0) return AckermanFunction(NumberM - 1, AckermanFunction(NumberM, NumberN - 1));
    return AckermanFunction(NumberM,NumberN);
}

int m = GetNumberFromConsole("Введите число M:");
int n = GetNumberFromConsole("Введите число N:");
Console.WriteLine($"А({m},{n}) = {AckermanFunction(m,n)}");