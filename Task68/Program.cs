// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();

int GetNum (string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int AkkermanFunction(int M, int N)
{
    int res = 0;
    if(M == 0)
    {
        res=N+1;
    }
    else if(M > 0 && N == 0)
    {
        res=AkkermanFunction(M-1, 1);
    }
    else if(M > 0 && N > 0)
    {
        res=AkkermanFunction(M-1, AkkermanFunction(M, N-1));
    }
    return res;
}

int M = GetNum("Введите число M: ");
int N = GetNum("Введите число N: ");

Console.WriteLine("Значение функции Аккермана равно: "+AkkermanFunction(M,N));