int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int CloseToHundred(ref int num1, ref int num2)
{
    if (100 - num1 < 100 - num2)
        return num1;  return num2;
}

Console.WriteLine(CloseToHundred(ref num1, ref num2));
