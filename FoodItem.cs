using System;
using System.Collections.Generic;
using System.Text;

namespace M3Assignment
{
    internal class FoodItem
    {
        // This is our storage - a List that holds strings (food names)
        private List<string> foodList = new List<string>();

        public void AddFoodItem(string itemName)
        {
            // Add the item to our list
            foodList.Add(itemName);
            Console.WriteLine($"Food item '{itemName}' added.");
        }

        public void DeleteFoodItem(string itemName)
        {
            // Check if the item exists in our list first
            if (foodList.Contains(itemName))
            {
                foodList.Remove(itemName);
                Console.WriteLine($"Food item '{itemName}' deleted.");
            }
            else
            {
                Console.WriteLine($"Food item '{itemName}' not found.");
            }
        }

        public void DisplayAllItems()
        {
            if (foodList.Count == 0)
            {
                Console.WriteLine("No food items in the list.");
            }
            else
            {
                Console.WriteLine("\n--- Food Items ---");
                foreach (string item in foodList)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine("------------------\n");
            }
        }
    }
}
