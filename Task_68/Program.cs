﻿// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

  int FunkAkkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if((m > 0) && (n == 0))
        {
            return FunkAkkerman(m - 1, 1);
        }
        else if((m > 0) && (n > 0))
        {
            return FunkAkkerman(m - 1, FunkAkkerman(m, n - 1));
        }else
        return n + 1;
    }
Console.Clear();
System.Console.WriteLine("Введите число M ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N ");
int n= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Функция Аккермана  равна {FunkAkkerman(m,n)}");