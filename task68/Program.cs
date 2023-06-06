// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите положительное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Ackerman(m, n)}");

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n > 0)
        return Ackerman(n - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}
// отчет у меня не совпадает, наверное ошибка в формуле, но я уже не вижу.
// пользовалась этой формулой, т.к. нашла ее, скорее всего неправильно записала
