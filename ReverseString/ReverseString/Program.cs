string text = "hello world";

char[] reverse(string text)
{
    char[] reverseString = new char[text.Length];
    int j = 0;
    for (int i = text.Length - 1; i >= 0; i--)
    {
        reverseString[j] = text[i];
        j++;
    }

    return reverseString;
}

Console.WriteLine(reverse(text));