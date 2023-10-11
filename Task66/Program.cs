//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

void PrintFactorial(int N, int M)
{
    Console.WriteLine("Сумма натуральных чисел от M до N:");
    Console.WriteLine(PrintNm(N,M));
}

int PrintNm (int N, int M)
{
    int sum = 0;
    while(N >= M)
    {
        sum = sum + N;
        N--;
    }
    return sum;
}

int N = 12;

int M = 4;

PrintFactorial(N, M);