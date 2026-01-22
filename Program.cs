//Need to allow user to add food items
//Need to allow user to delete food items
//Need to print the list of food items

using M3Assignment;

FoodItem fi = new FoodItem();

string foodItem = "";

Console.WriteLine("Welcome to the Food Item Manager!");
Console.WriteLine("Press 1 if you want to add an item, press 0 if you want to delete an item.");
string addDelete = Console.ReadLine();
if (addDelete == "1")
{
    fi.AddFoodItem();
}
else
{
    fi.DeleteFoodItem();
}

//foodItem = Console.ReadLine();

//Would it be optimal to write an if statement here?
