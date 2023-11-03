int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

int SumOfEven(int[] arr)
{
    int SumOfEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            SumOfEven += arr[i];
        else continue;
    }
    return SumOfEven;
}

Console.WriteLine(SumOfEven(arr));