//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int N = Convert.ToInt32(Console.ReadLine());




int akkerFunction (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return akkerFunction(M - 1, 1);
    if (M > 0 && N > 0) return akkerFunction(M - 1, akkerFunction(M, N - 1));
return akkerFunction(M, N);
}

Console.WriteLine($"Функция Аккермана для чисел ({M},{N}) = {akkerFunction(M, N)}");
