/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
// 1. Получение числа от пользователя.
int GetCorrectNumber(string message)
{
    int correctNumber = 0;
    while (true)
    {
        Console.Write($"{message}: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber >= 0)
            return correctNumber;
        else
            Console.WriteLine("Введенные данные не корректны!");
    }
}
int n = GetCorrectNumber("Введите первый аргумент n");
int m = GetCorrectNumber("Введите второй аргумент m");

// 2. Функция Аккермана.
int FunctionOfAccerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n > 0 && m == 0)
        return FunctionOfAccerman(n - 1, 1);
    else
        return FunctionOfAccerman(n - 1, FunctionOfAccerman(n, m - 1));
}

// 3. Вывод в консоль.
Console.WriteLine($"A({n},{m}) = {FunctionOfAccerman(n, m)}");