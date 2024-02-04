// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

 int[] Random_mas(int[] col) //На вход функция получает тоже целочисленный массив "Col"(название может быть любое)
{
    for (int i = 0; i < col.Length; i++) //этот метод поймет сколько элементов в нашем массиве
    {
        col[i] = new Random().Next(1, 20);
        Console.Write($"{col[i]} ");
    }
    Console.WriteLine(); 
    return col; 
     
}

void PrintArray(int[] mas, int i = 0)
{
    if(i < mas.Length)                 // условие выхода из рекурсии
    {
        PrintArray(mas, i + 1); //рекурсия
        Console.Write($"{mas[i]} ");
    }
}


int[] massive = Random_mas(new int[10]);
PrintArray(massive);
