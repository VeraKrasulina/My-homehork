// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 1;
int b = 0;
while (a <= num)
{
    b = Convert.ToInt32 ( Math.Pow (a, 3));
    Console.Write ($"{b} ");
    a++;
}
