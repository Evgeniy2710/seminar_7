// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9
int SumNum(int num)
{
        if(num == 0) return 0; //Способ выхода из реукурсии
        int res = num % 10 + SumNum(num / 10); // Маетематическая операция + реукрсия.
        return res; // взвращаемое значение итога работы функции
}



Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(SumNum(n));
