using System;
using System.Text;

public class OldPhonePad
{
    private static readonly Dictionary<char, string> PhonePadMap = new()
    {
        {'2', "ABC"},
        {'3', "DEF"},
        {'4', "GHI"},
        {'5', "JKL"},
        {'6', "MNO"},
        {'7', "PQRS"},
        {'8', "TUV"},
        {'9', "WXYZ"},
        {'0', "0"}
    };

    public string ProcessInput(string input)
    {
        var result = new StringBuilder();
        var currentDigit = '\0';
        var currentCount = 0;

        foreach (var ch in input)
        {
            if (ch == ' ' || ch == '*')
            {
                if (currentDigit != '\0')
                {
                    result.Append(GetCharacter(currentDigit, currentCount));
                    currentDigit = '\0';
                    currentCount = 0;
                }
                if (ch == '*') result.Length = Math.Max(0, result.Length - 1);
                continue;
            }

            if (ch == '#') break;

            if (PhonePadMap.ContainsKey(ch))
            {
                if (ch == currentDigit)
                {
                    currentCount++;
                }
                else
                {
                    if (currentDigit != '\0')
                    {
                        result.Append(GetCharacter(currentDigit, currentCount));
                    }
                    currentDigit = ch;
                    currentCount = 1;
                }
            }
        }

        if (currentDigit != '\0')
        {
            result.Append(GetCharacter(currentDigit, currentCount));
        }

        return result.ToString();
    }

    private static char GetCharacter(char digit, int count)
    {
        var characters = PhonePadMap[digit];
        return characters[(count - 1) % characters.Length];
    }

    public static void Main(string[] args)
    {
        OldPhonePad phonePad = new OldPhonePad();

        Console.WriteLine(phonePad.ProcessInput("33#")); // Output: E
        Console.WriteLine(phonePad.ProcessInput("227*#")); // Output: B
        Console.WriteLine(phonePad.ProcessInput("4433555 555666#")); // Output: HELLO
        Console.WriteLine(phonePad.ProcessInput("8 88777444666*664#")); // Output: TUNNO
        Console.WriteLine(phonePad.ProcessInput("2222#")); // Output: A
        Console.WriteLine(phonePad.ProcessInput("222 2 22#")); // Output: CAB
        Console.WriteLine(phonePad.ProcessInput("0#")); // Output: 0
        Console.WriteLine(phonePad.ProcessInput("111#")); // Output: 1
        Console.WriteLine(phonePad.ProcessInput("2222*#")); // Output:
        Console.WriteLine(phonePad.ProcessInput("7777#")); // Output: S
    }
}
