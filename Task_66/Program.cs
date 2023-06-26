// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
//  сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// nt Summa(int num)
// {
//     int sum = 0;
//     while (true)
//     {
//         sum+=num;
//         num--;
//         if (num==0)
//             break;
//     }
//     return sum;
// }

int SummaRec(int numM, int numN)
{
    if (numM==numN+1)  return 0;
    return numM +  SummaRec(numM+1,numN) ;
}

//SummaRec(4)
//4 + (3 + (2 + (1 + 0)))


Console.Clear();
System.Console.WriteLine("Введите число M, с которого начинать: ");
int numM = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N, до которого считать сумму: ");
int numN = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма всех натуральных чисел от {numM} до {numN} равна {SummaRec(numM,numN)}");

