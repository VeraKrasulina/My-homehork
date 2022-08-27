Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <100) Console.WriteLine ("Введенное число не содержит третьего числа.");
int num1 = 0;

while (num > 1000)
{
    num = num / 10;
}
int num3 = num % 10;

Console.WriteLine (num3);