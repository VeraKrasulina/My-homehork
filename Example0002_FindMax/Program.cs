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

// Fill paramether new int [????] to create a different quantity of numbers within massive
int[] numbers = new int [3];
FillArray (numbers);

int ind = 0;
int max = numbers[ind];
int length = numbers.Length;
while (ind < length)
{
    if (max < numbers[ind])
    {
        max = numbers [ind];
    }
ind = ind+1;
}

Console.WriteLine ("Из представленных чисел: ");
PrintArrey (numbers);
Console.WriteLine ($"{max} является максимальным.");