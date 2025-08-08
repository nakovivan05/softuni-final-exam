using System;
using System.Text;

class Program
{
    static void Main()
    {
        string spell = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(spell);
        string input;
        while((input = Console.ReadLine()) != "Abracadabra")
        {
            string[]commandInfo = input.Split(' ').ToArray();
            string command = commandInfo[0];
            if(command == "Abjuration")
            {
                sb = new StringBuilder(sb.ToString().ToUpper());
                Console.WriteLine(sb.ToString());
            }
            else if (command == "Necromancy")
            {
                sb = new StringBuilder(sb.ToString().ToLower());
                Console.WriteLine(sb.ToString());
            }
            else if(command == "Illusion")
            {
                int index = int.Parse(commandInfo[1]);
                char letter = char.Parse(commandInfo[2]);
                if(index >= 0 && index<sb.Length)
                {
                    sb[index] = letter;
                    Console.WriteLine("Done!");
                }
                else
                {
                    Console.WriteLine("The spell was too weak.");
                }
            }
            else if( command == "Divination")
            {
                string firstSubstring = commandInfo[1];
                string secondSubstring = commandInfo[2];
                if(sb.ToString().IndexOf(firstSubstring)!=-1)
                {
                    sb.Replace(firstSubstring, secondSubstring);
                    Console.WriteLine(sb.ToString());
                }
            }
            else if(command == "Alteration")
            {
                string substring = commandInfo[1];
                sb = new StringBuilder(sb.ToString().Replace(substring, ""));

                Console.WriteLine(sb.ToString());
                
            }
            else
            {
                Console.WriteLine("The spell did not work!");
            }
        }
    }
}