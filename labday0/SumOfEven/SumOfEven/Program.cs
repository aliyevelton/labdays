int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

bool Check(ref int num1, ref int num2)
{
    if (num1 == 30 || num2 == 30)
        return true;
    else if (num1 + num2 == 30)
        return true;
    else return false;
}

Console.WriteLine(Check(ref num1, ref num2));