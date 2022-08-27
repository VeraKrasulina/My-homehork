Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10000 | num > 99999) Console.WriteLine ("Введенное число не является пятизначным.");

int ttousands = num /10000;
int tousands = (num / 1000) % 10;
int hundreds = ((num / 100) % 100) % 10;
int tens = (num /10) % 10;
int ones = num % 10;

// Console.WriteLine(ttousands);
// Console.WriteLine(tousands);
// Console.WriteLine(hundreds);
// Console.WriteLine(tens);
// Console.WriteLine(ones);

if (ttousands == ones && tousands == tens)
{
    Console.WriteLine ($"Число {num} является палиндромом.");
}
else Console.WriteLine ($"Число {num} не является палиндромом.");