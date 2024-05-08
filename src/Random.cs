using System;
using System.IO;

class C
{
    public static string GetNameToCheck(string input)
    {
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
