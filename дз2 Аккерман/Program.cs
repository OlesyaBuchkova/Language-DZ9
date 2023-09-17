// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Print(string text) 
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
} 
int Akkerman(int M, int N)
{
    if (M == 0) 
    {
        return N + 1;
    }
    else if (M > 0 && N == 0) 
    {
        return Akkerman(M - 1, 1);
    }
    else 
    {
    return Akkerman(M - 1, Akkerman(M, N - 1));
    }
}
int M = Print("Введите неотрицательное число M: ");
int N = Print("Введите неотрицательное число N: ");
Console.Write($"Функция Аккермана равно {Akkerman(M, N)} ");
