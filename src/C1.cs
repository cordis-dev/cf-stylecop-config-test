using System;
using System.IO;

class C
{
    public bool Enabled
    {
        get
        {
            return true;
        }
    }

    public static string GetNameToCheck(string input)
    {
        do
        {
            Console.WriteLine("Loop forever");
        }
        while (true);

        if (input.Contains('\\', StringComparison.Ordinal))
        {
            return input.Substring(0, input.IndexOf('\\'));
        }

        return Path.GetFileNameWithoutExtension(input);
    }

    public static bool IsValid(string input)
    {
        return input.StartsWith("{") && input.EndsWith('}');
    }
}
