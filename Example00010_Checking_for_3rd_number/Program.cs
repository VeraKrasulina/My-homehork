Console.Write("Введите число: ");
string num = Console.ReadLine();
char [] array = num.ToCharArray();
int length = array.Length;
if (length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(num[2]);
}
