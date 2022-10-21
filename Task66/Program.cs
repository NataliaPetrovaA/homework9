// Задача 66. Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

double SumNaturalElements(double startNumber, double lastNumber)
{
    double result = 0;
    if (startNumber < lastNumber)
    {
        result = startNumber + SumNaturalElements(startNumber + 1, lastNumber);
    }
    else if (startNumber == lastNumber)
    {
         result = result + lastNumber;
    }
    return result;
}

double m = Math.Ceiling(GetNumberFromConsole("Введите число M:"));
double n = Math.Truncate(GetNumberFromConsole("Введите число N:"));
Console.WriteLine($"M = {m}; N = {n}; -> {SumNaturalElements(m, n)} (Сумма натуральных элементов)");