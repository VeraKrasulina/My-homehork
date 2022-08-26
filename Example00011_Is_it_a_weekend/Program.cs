Console.Write("Введите номер дня недели: ");
int num = int.Parse (Console.ReadLine());
if (num > 7)
{
    Console.WriteLine("Некорректное значение");
}
else if (num > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}