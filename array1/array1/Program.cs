int[] numbers = { 1, 2, 3, 4, 5, 6 };
int a = 2;

int IndexOf(int[] numbers, int a)
{
    int found = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (a == numbers[i])
        {
            found = i; break;
        }

    }
    if (found == 0)
    {
        found = -1;
    }
    return found;
}

Console.WriteLine(IndexOf(numbers, a));