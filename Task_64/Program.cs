/* Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"        */
// Получение числа от пользователя.
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
int n = GetNumber("Введите число: ");

// 2. Нахождение всех натуральных чисел от 1 до N
void NaturalForN(int n)
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        NaturalForN(n - 1);
    }
    else
        Console.WriteLine(1);
}
NaturalForN(n);













