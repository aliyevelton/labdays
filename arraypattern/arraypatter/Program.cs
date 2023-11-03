string input = Console.ReadLine();

string  Pattern(ref string input)
{
    string result = string.Empty;
    string result0 = string.Empty;

    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        result0 += c;
        result += result0;
    }
    return result;
}

Console.WriteLine(Pattern(ref input));