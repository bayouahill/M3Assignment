//Need to allow user to add food items
//Need to allow user to delete food items
//Need to print the list of food items

using System;
using System.Collections.Generic;

namespace M3Assignment
{
    class Program
    {
        static List<FoodItem> inventory = new List<FoodItem>();

        //Method to interact with the user of the food bank
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4)
            {
                Console.WriteLine("\n=== Food Bank Inventory System ===");
                Console.WriteLine("1. Add Food Item");
                Console.WriteLine("2. Delete Food Item");
                Console.WriteLine("3. Print List of Current Food Items");
                Console.WriteLine("4. Exit Program");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddFoodItem();
                        break;
                    case 2:
                        DeleteFoodItem();
                        break;
                    case 3:
                        PrintInventory();
                        break;
                    case 4:
                        Console.WriteLine("Adios!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        //Method to add new item
        static void AddFoodItem()
        {
            Console.Write("\nEnter food name: ");
            string name = Console.ReadLine();

            Console.Write("Enter category: ");
            string category = Console.ReadLine();

            int quantity;
            while (true)
            {
                Console.Write("Enter quantity: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid quantity. Please enter a positve number.");
            }

            DateTime expirationDate;
            while (true)
            {
                Console.Write("Enter expiration date (MM/DD/YYYY): ");
                if (DateTime.TryParse(Console.ReadLine(), out expirationDate))
                {
                    break;
                }
                Console.WriteLine("Invalid date format. Please use MM/DD/YYYY");
            }
            
            FoodItem newItem = new FoodItem(name, category, quantity, expirationDate);
            inventory.Add(newItem);

            Console.WriteLine("Item added!!");
        }

        //Method to delete food item
        static void DeleteFoodItem()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("\nInventory is empty. Nothing to delete.");
                return;
            }

            Console.WriteLine("\n=== Current Inventory ===");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i}. {inventory[i]}");
            }

            Console.Write("\nEnter the number of items to delete: ");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= inventory.Count)
            {
                Console.WriteLine("Invalid item number");
                return;
            }

            inventory.RemoveAt(index);
            Console.WriteLine("Item deleted");
        }

        //Method to print entire directory of the food bank
        static void PrintInventory()
        {
            if (inventory.Count == 0)
            {
                Console.WriteLine("\nInventory is empty.");
                return;
            }

            Console.WriteLine("\n=== Current Food Items ===");
            foreach (FoodItem item in inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}


//foodItem = Console.ReadLine();

//Would it be optimal to write an if statement here?
