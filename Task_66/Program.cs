/*
Задача 66: Задайте значения M и N. 
Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30          */

// Получение значений M and N из консоли.
int GetNumber(string message)
{
    int resultNumber = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out resultNumber))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введеное число не корректно. Попробуйте еще раз.");
        }
    }
    return resultNumber;
}
Console.WriteLine("Чтобы найти сумму натуральных чисел от M до N:");
int M = GetNumber("1) введите число M: ");
int N = GetNumber("2) введите число N: ");

// 2. Сумма натуральных чисел в промежутке от M до N.
int SumNaturalDigit(int M, int N)
{
    int sum = 0;
    if (M <= N)
    {
        sum = M + SumNaturalDigit(M + 1, N);
    }
    return sum;
}

//  3. Вывод в консоль.
Console.WriteLine(SumNaturalDigit(M, N));