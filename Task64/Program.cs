// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbersRecursionVoid(double startNumber, int lastNumber)
{
    if (startNumber >= lastNumber)
    {
        Console.Write(startNumber + ", ");
        WriteNumbersRecursionVoid(startNumber-1, lastNumber);
    }     
}

double number = Math.Truncate(GetNumberFromConsole("Введите число N:"));
WriteNumbersRecursionVoid(number, 1);