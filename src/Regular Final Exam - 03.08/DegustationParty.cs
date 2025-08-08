using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input;
        var meals = new Dictionary<string, List<string>>();
        int countOfUnlikedMeals = 0;
        while ((input = Console.ReadLine()) != "Stop")
        {
            string[]command = input.Split('-').ToArray();
            string action = command[0];
            string guestName = command[1];
            string meal = command[2];
            if (action == "Like")
            {
                if (!meals.ContainsKey(guestName))
                {
                    meals[guestName] = new List<string>();
                    meals[guestName].Add(meal);
                }
                else
                {
                    if (!meals[guestName].Contains(meal))
                    {
                        meals[guestName].Add(meal);
                    }
                }
            }
            else if(action == "Dislike")
            {
                if (meals.ContainsKey(guestName))
                {
                    if (meals[guestName].Contains(meal))
                    {
                        meals[guestName].Remove(meal);
                        countOfUnlikedMeals++;
                        Console.WriteLine($"{guestName} doesn't like the {meal}.");
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                    }


                }
                else
                {
                    Console.WriteLine($"{guestName} is not at the party.");
                }
            }
        }
        foreach (string guest in meals.Keys)
        {
            Console.Write($"{guest}: ");
            if (meals[guest].Count > 0)
            {
                for (int i = 0; i < meals[guest].Count; i++)
                {
                    if (i == meals[guest].Count - 1)
                    {
                        Console.WriteLine($"{meals[guest][i]}");
                        break;
                    }
                    else
                    {
                        Console.Write($"{meals[guest][i]}, ");
                    }
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine($"Unliked meals: {countOfUnlikedMeals}");
    }
}

