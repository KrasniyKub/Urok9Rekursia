//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();

void PrintNfactorial(int N)
{
    Console.WriteLine("Натуральные числа от 1 до N:");
    PrintN(N);
}

void PrintN (int N)
{
    Console.Write(N+" ");
    N--;
    if (N >= 1)
    {
        PrintN(N);
    }
    else
    {
        Console.WriteLine();
    }
}

int N = 15;
PrintNfactorial(N);