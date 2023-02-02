// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int number1, int number2, int number3)
{
    if (number1 == number2+1)
    {
        return number3;
    }
    return number3 = number1 + Sum(number1 + 1, number2, number3);
}

Console.WriteLine("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int N = Convert.ToInt32(Console.ReadLine());
int Z = 0;
int sum = Sum(M, N, Z);
Console.WriteLine(sum);