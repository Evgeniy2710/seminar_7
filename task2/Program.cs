// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

// string Len(int start, int stop)
// {
//     if (start == stop) return Convert.ToString(start);
//     return start + " " + Len(start + 1, stop);
// }


// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine(Len(1, n));

//Второй способ

void Len(int num)
{
    if(num == 0)return;
    Len(num - 1);
    Console.Write($"{num} "); 
}


Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()!);
Len(n);