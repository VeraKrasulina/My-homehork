Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <100 | num > 999) Console.WriteLine ("Введенное число не трехзначное.");
// int hundreds = num / 100;
int ones = num % 10;
int tens = ((num % 100) - ones) / 10;

Console.WriteLine($"Второе число в этой цифре - {tens}");
