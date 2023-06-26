﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string GetNumbersRec(int num)
{
    if (num == 0)  return "";
    return   num + " " + GetNumbersRec(num - 1);    
}
Console.Clear();
System.Console.WriteLine("Введите целое число ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Все натуральные числа от {num} до 1:");
System.Console.WriteLine(GetNumbersRec(num));