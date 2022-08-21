void FillArray (int [] arrey)
{
int length = arrey.Length;
int index = 0;

while (index < length)
{
    arrey[index] = new Random ().Next (-100,100);
    index++;
}
}

void PrintArrey (int [] list)
{
    int count = list.Length;
    int pos = 0;

    while (pos < count)
    {
        Console.WriteLine (list[pos]);
        pos++;
    }
}

Console.Write ("Введите количество чисел в массиве: ");
int n = int.Parse (Console.ReadLine());
int[] numbers = new int [n];
FillArray (numbers);
int ind = 0;
int vol = 0;

while (ind < n)
{
    if (numbers[ind] % 2 == 0)
        {
            Console.WriteLine (numbers[ind]);
            vol++;
        }
    ind++;
}
Console.WriteLine($"Всего найдено {vol} четных чисел.");
