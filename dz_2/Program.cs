// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// Пример:
// m = 3, n = 2 -> A(m,n) = 29


            int A(int m, int n)
            {
                if (m == 0) return n + 1;

                if (m > 0 && n == 0) return A(m - 1, 1);

                if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));

                return A(m,n);
            }
            

            // для M максимум 3
            // для N максимум 4
            
            Console.Write("Введите число m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(A(m, n));