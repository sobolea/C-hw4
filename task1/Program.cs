// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A, B;
Console.Write("Введите А: ");
int.TryParse(Console.ReadLine(), out A);
Console.Write("Введите B: ");
int.TryParse(Console.ReadLine(), out B);

Console.Write($"{A}, {B} -> {Exponent(A, B)}");

int Exponent(int a, int b)
{
    int aa = a;
    for (int i = 2; i <= b; i++)
        aa *= a;
    return aa;
}