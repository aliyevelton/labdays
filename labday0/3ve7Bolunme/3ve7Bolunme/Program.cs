int number = int.Parse(Console.ReadLine());

bool Division(ref int number)
{
    if (number % 7 == 0 || number % 3 == 0) 
        return true; return false;
}

Console.WriteLine(Division(ref number));