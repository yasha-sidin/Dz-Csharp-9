// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Рекурсивная сумма натуральных элементов от M до N
int GetSumInRange(int startRange, int endRange)
{
    if (startRange - 1 == endRange)
    {
        return 0;
    }

    return endRange + GetSumInRange(startRange, endRange - 1);
}

Console.WriteLine("Введите начало диапозона: ");
int startRange = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конец диапозона: ");
int endRange = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма всех элементов от {startRange} до {endRange} = {GetSumInRange(startRange, endRange)}");