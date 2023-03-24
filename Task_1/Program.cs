// Задача 1: Задайте значение N. Напишите программу, 
// которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.
// M, N = 5, 8 -> "6, 8"
// M, N = 2, 4 -> "2, 4"

// Рекурсивный вывод четных чисел от M до N
void GetEvenInRange(int startRange, int endRange)
{
    if (endRange == startRange - 1) return;
    GetEvenInRange(startRange, endRange - 1);
    if (endRange % 2 == 0) Console.Write($"{endRange} ");

}
int startRange = int.Parse(Console.ReadLine());
int endRange = int.Parse(Console.ReadLine());
GetEvenInRange(startRange, endRange);