Console.Write("Введите трехзначное число: ");
string num = Console.ReadLine();
char [] array = num.ToCharArray();
int length = array.Length;
if (length != 3)
{
    Console.WriteLine("Число не является трехзначным");
}
else
{
    Console.WriteLine(num[1]);
}