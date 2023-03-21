// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int A;
Console.Write("Введите число: ");
int.TryParse(Console.ReadLine(), out A);

Console.Write($"{A} -> {Sum(A)}");

int Sum(int a)
{
    int aa = a;
    int sum = 0;
    while (aa > 0)
    {
        sum = sum + ( aa % 10);
        aa = aa / 10;
    }
    return sum;
}

// int aa = A;
// int sum = 0;
// while (aa > 0)
// {
//     sum = sum + ( aa % 10);
//     Console.WriteLine(aa);
//     aa = aa / 10;
//     Console.WriteLine(aa);
// }
// Console.Write(aa);