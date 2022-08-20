Console.Write ("Введите первое число: ");
double number1 = double.Parse (Console.ReadLine());
Console.Write ("Введите второе число: ");
double number2 = double.Parse (Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine ($"По результатам сравнения {number1} > {number2}");
}
else Console.WriteLine ($"По результатам сравнения {number2} > {number1}");
