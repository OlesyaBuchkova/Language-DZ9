// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Print(string text) 
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int SumNumber (int M, int N)
{
    if (M == N)
    {
        return M;
    }
    return N + SumNumber(M, N - 1);
}

int M = Print("Введите число M: ");
int N = Print("Введите число N: ");
Console.WriteLine(SumNumber(M, N));
