// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

string Len(int start, int stop)
{
    if (start == stop) return Convert.ToString(start);
    return start + " " + Len(start + 1, stop);
}

Console.WriteLine("Введите начальное число:");
int sta = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите конечное число:");
int sto = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine(Len(sta, sto));
