using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        int numberOfInputs = int.Parse(Console.ReadLine());
        string pattern = @"^([$%])([A-Z][a-z]{2,})\1: \[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|$";
        for (int i = 0; i < numberOfInputs; i++)
        {
            string message = Console.ReadLine();
            Match match = Regex.Match(message, pattern);
            if (match.Success)
            {
                string tag = match.Groups[2].Value;
                char symbol1 = (char)int.Parse(match.Groups[3].Value);
                char symbol2 = (char)int.Parse(match.Groups[4].Value);
                char symbol3 = (char)int.Parse(match.Groups[5].Value);
                string decryptedMessage = $"{tag}: {symbol1}{symbol2}{symbol3}";
                Console.WriteLine(decryptedMessage);
            }
            else
            {
                Console.WriteLine("Valid message not found!");
            }
        }
    }
}
