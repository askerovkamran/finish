// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
SumElement(M, N);

//------------------Метод-------------------
void SumElement(int m, int n)
{
    Console.Write(sum(m - 1, n));
}
int sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + sum(m, n);
        return res;
    }
}