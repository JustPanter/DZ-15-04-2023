// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);
int a = 1;
int i = 1;
while(i < N + 1)
{
    Console.Write($"{a} ");
    i++;
    Console.WriteLine(a * a * a);
    a++;
}