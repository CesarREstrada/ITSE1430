// Cesar Estrada
// ITSE 1430 
// MW 5:00pm
// September 17, 2018
// Pizza Maker

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Pizza_Creator
{
	class Program
	{
		static void Main(string[] args)
		{
			
			bool notQuit;
			do
			{
				notQuit = DisplayMenu();
			} while (notQuit);
		}

		private static bool DisplayMenu()
		{
			while (true)
			{
				Console.WriteLine("Please Select one of the menu options.\n");
				Console.WriteLine("\t1. New Order");
				Console.WriteLine("\t2. Modify Order");
				Console.WriteLine("\t3. Display Order");
				Console.WriteLine("\t4. Quit");

				string input = Console.ReadLine();
				Console.Write("\n");
				switch (input[0])
				{
					case '1':
						NewOrder();
						return true;

					case '2':
						ModifyOrder();
						return true;

					case '3':
						DisplayOrder();
						return true;

					case '4':
						return false;

					default:
						Console.WriteLine("Please enter a valid value\n\n");
						break;
				};

			};
		}

		private static bool NewOrder()
		{
			while (true)
			{
				Console.WriteLine("Choose the size of your pizza\n");
				Console.WriteLine("\t1. Small    $5.00");
				Console.WriteLine("\t2. Medium   $6.25");
				Console.WriteLine("\t3. Large    $8.75");
				Console.WriteLine("\t4. Return to main menu");

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':
						if (choice == 1)
						{
							pizzaSize = "Small Pizza";
							pizzaPrice = 5.00m;
							displaySize[0] = true;
						}
						SmallPizza();
						return true;

					case '2':
						if (choice == 2)
						{
							pizzaSize = "Medium Pizza";
							pizzaPrice = 6.25m;
							displaySize[1] = true;
						}
						MediumPizza();
						return true;

					case '3':
						if (choice == 3)
						{
							pizzaSize = "Large Pizza";
							pizzaPrice = 8.75m;
							displaySize[2] = true;
						}
						LargePizza();
						return true;

					case '4':
						return true;

					default:
						Console.WriteLine("Please enter a valid value.\n\n");
						break;
				};
			}
		}

		private static void ModifyOrder()
		{
			Console.WriteLine("Modify Order\n");
		}

		private static void DisplayOrder()
		{
			//if (displaySize[3] == false)
			//{
			//	Console.WriteLine("No order is available to view at this time.\n");
			//	return;
			//}
			bool flag = false;

			for (int i = 0; i < displayCount; ++i)
			{				
				if (displaySize[i] == true)
				{
					flag = true;
					var receipt = "Your Order";
					Console.WriteLine($"\n\n\t{receipt.PadLeft(20)}");
					Console.WriteLine($"\t{pizzaSize}{pizzaPrice,15:C}");

					// take out or delivery
					for (int j = 0; j < count; ++j)
					{
						if (delivery[j] == true)
						{
							Console.WriteLine($"\t{deliveryOptions[i]}{deliveryPrice,18:C}");
						}
					}

					// Meat Choices
					if (meat == true)
					{
						Console.WriteLine("\tMeats");
					}
					for (int j = 0; j < count; ++j)
					{
						if (meatChoices[j] == true)
						{
							Console.WriteLine($"\t   {meats[i].PadRight(10)}{meatPrice,13:c}");
						}
					}

					// Vegetables
					if (veg == true)
					{
						Console.WriteLine("\tVegetables");
					}
					for (int j = 0; j < count; ++j)
					{
						if (vegChoices[j] == true)
						{
							Console.WriteLine($"\t   {vegetables[i].PadRight(12)}{meatPrice,11:c}");
						}
					}

					// Sauces				
					Console.WriteLine("\tSauce");
					for (int j = 0; j < count; ++j)
					{
						if (sauceChoices[j] == true)
						{
							Console.WriteLine($"\t   {sauces[i].PadRight(12)}{saucePrice,11:c}");
						}
					}

					// cheese
					Console.WriteLine("\tCheese");
					for (int j = 0; j < count; ++j)
					{
						if (cheese[j] == true)
						{
							Console.WriteLine($"\t   {cheeseChoices[i].PadRight(12)}{cheesePrice,11:c}");
						}
					}

					//total
					totalPrice = meatTotal + vegTotal + saucePrice + cheesePrice + deliveryPrice;
					Console.WriteLine("\t---------------------------");
					Console.WriteLine($"\tTotal{totalPrice,21:c}\n");
					
				}				
			}

			if (flag == false)
			{
				Console.WriteLine("No order is available to view at this time.\n");
			}
				//if (String.IsNullOrEmpty(pizzaChoice))
				//{
				//	Console.WriteLine("No order is available to view at this time.");
				//	return;
				//};


			}

		private static bool SmallPizza()
		{
			string[] remove = { "B", "H", "P", "S" };

			while (true)
			{
				Console.WriteLine("Toppings for your SMALL PIZZA\n");
				Console.WriteLine("Select your meats toppings or continue to vegetable toppings\n");
				Console.WriteLine("\t1. Bacon       $0.75");
				Console.WriteLine("\t2. Ham         $0.75");
				Console.WriteLine("\t3. Pepperoni   $0.75");
				Console.WriteLine("\t4. Sausage     $0.75");
				Console.WriteLine("\t5. Continue to vegetable toppings\n\n");


				// running total
				Console.WriteLine($"{pizzaSize} {pizzaPrice,15:C}");
				Console.WriteLine($"Meat toppings {meatTotal,13:C}");
				
				var meats = new List<string>();
				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);
				
				switch (input[0])
				{

					case '1':
						if (choice == 1)
						{
							meatChoices[0] = true;
							meatTotal += meatPrice;
							meat = true;							
						}
						SmallPizza();
						return true;
					
					case '2':
						if (choice == 2)
						{
							meatChoices[1] = true;
							meatTotal += meatPrice;
							meat = true;						
						}
						SmallPizza();
						return true;

					case '3':
						if (choice == 3)
						{
							meatChoices[2] = true;
							meatTotal += meatPrice;
							meat = true;
						}
						SmallPizza();
						return true;

					case '4':
						if (choice == 4)
						{
							meatChoices[3] = true;
							meatTotal += meatPrice;
							meat = true;
						}
						SmallPizza();
						return true;

					case '5':
						VegToppings();
						return true;

					default:
						Console.WriteLine("Please enter a valid value\n\n.");
						break;
				};

			}
		}

		private static void MediumPizza()
		{
			Console.WriteLine("Medium Pizza\n");
		}

		private static void LargePizza()
		{
			Console.WriteLine("Large Pizza\n");
		}

		private static bool VegToppings()
		{

			while (true)
			{

				Console.WriteLine("Select your vegetable toppings or continue to your sauce choices\n");
				Console.WriteLine("\t1. Black Olives   $0.50");
				Console.WriteLine("\t2. Mushrooms      $0.50");
				Console.WriteLine("\t3. Onions         $0.50");
				Console.WriteLine("\t4. Peppers        $0.50");
				Console.WriteLine("\t5. Continue to sauce choices\n\n");

				// running total
				Console.WriteLine($"{pizzaSize} {pizzaPrice,15:C}");
				Console.WriteLine($"Meat toppings {meatTotal,13:C}");
				Console.WriteLine($"Vegetable toppings {vegTotal,8:C}");

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':
						if (choice == 1)
						{
							vegChoices[0] = true;
							vegTotal += vegPrice;
							veg = true;
						}
						VegToppings();
						return true;

					case '2':
						if (choice == 2)
						{
							vegChoices[1] = true;
							vegTotal += vegPrice;
							veg = true;
						}
						VegToppings();
						return true;

					case '3':
						if (choice == 3)
						{
							vegChoices[2] = true;
							vegTotal += vegPrice;
							veg = true;
						}
						VegToppings();
						return true;

					case '4':
						if (choice == 4)
						{
							vegChoices[3] = true;
							vegTotal += vegPrice;
							veg = true;
						}
						VegToppings();
						return true;

					case '5':
						SauceSelection();
						return true;

					default:
						Console.WriteLine("Please enter a valid value.");
						break;
				};
			}
		}

		private static bool SauceSelection()
		{

			while (true)
			{

				Console.WriteLine("Select your sauce (one is required)\n");
				Console.WriteLine("\t1. Traditional   $0.00");
				Console.WriteLine("\t2. Garlic        $1.00");
				Console.WriteLine("\t3. Oregano       $1.00\n");
				//Console.WriteLine("\t4. Continue to cheese options\n\n");

				// running total
				Console.WriteLine($"{pizzaSize} {pizzaPrice,15:C}");
				Console.WriteLine($"Meat toppings {meatTotal,13:C}");
				Console.WriteLine($"Vegetable toppings {vegTotal,8:C}");
				Console.WriteLine($"Sauce options {saucePrice,13:C}");


				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':
						if (choice == 1)
						{
							sauceChoices[0] = true;							
						}
						Cheese();
						return true;

					case '2':
						if (choice == 2)
						{
							sauceChoices[1] = true;
							saucePrice = 1.00m;
						}
						Cheese();
						return true;

					case '3':
						if (choice == 3)
						{
							sauceChoices[2] = true;
							saucePrice = 1.00m;
						}
						Cheese();
						return true;

					default:
						Console.WriteLine("Please enter a valid value.");
						break;
				};

			}
		}
		private static bool Cheese()
		{
			while (true)
			{
				Console.WriteLine("Select your cheese (one is required)\n");
				Console.WriteLine("\t1. Regular   $0.00");
				Console.WriteLine("\t2. Extra     $1.25\n\n");
				//Console.WriteLine("\t3. Continue to delivery options\n\n");

				// running total
				Console.WriteLine($"{pizzaSize} {pizzaPrice,15:C}");
				Console.WriteLine($"Meat toppings {meatTotal,13:C}");
				Console.WriteLine($"Vegetable toppings {vegTotal,8:C}");
				Console.WriteLine($"Sauce options {saucePrice,13:C}");
				Console.WriteLine($"Cheese options {cheesePrice,12:C}\n");

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':
						if (choice == 1)
						{
							cheese[0] = true;
						}
						Delivery();
						return true;

					case '2':
						if (choice == 2)
						{
							cheese[1] = true;
							cheesePrice = 1.25m;
						}
						Delivery();
						return true;

					default:
						Console.WriteLine("Please enter a valid value.");
						break;
				};
			}
		}

		private static bool Delivery()
		{
			while (true)
			{
				Console.WriteLine("Select your delivery option (one is required)\n");
				Console.WriteLine("\t1. Take out   $0.00");
				Console.WriteLine("\t2. Delivery   $2.50\n\n");
				//Console.WriteLine("\t3. Continue to delivery options\n\n");

				// running total
				Console.WriteLine($"{pizzaSize} {pizzaPrice,15:C}");
				Console.WriteLine($"Meat toppings {meatTotal,13:C}");
				Console.WriteLine($"Vegetable toppings {vegTotal,8:C}");
				Console.WriteLine($"Sauce options {saucePrice,13:C}");
				Console.WriteLine($"Cheese options {cheesePrice,12:C}\n\n");


				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':
						if (choice == 1)
						{
							delivery[0] = true;							
						}
						DisplayOrder();
						return true;

					case '2':
						if (choice == 2)
						{
							delivery[1] = true;
							deliveryPrice = 2.50m;
						}
						DisplayOrder();
						return true;

					default:
						Console.WriteLine("Please enter a valid value.");
						break;
				};
			}
		}


		static int count = 4;

		// pizza sizes
		static string pizzaSize;
		static decimal pizzaPrice;

		// meat toppings
		static string[] meats = { "Bacon", "Ham", "Pepperoni", "Sausage" };
		static bool[] meatChoices = new bool[count];
		static bool meat;
		static decimal meatPrice = 0.75m;
		static decimal meatTotal;


		// veg toppings
		static string[] vegetables = {"Black Olives", "Mushrooms", "Onions", "Peppers" };
		static bool veg;
		static bool[] vegChoices = new bool[count];
		static decimal vegPrice = 0.50m;
		static decimal vegTotal;

		// Sausce options
		static string[] sauces = { "Traditional", "Garlic", "Oregano" };		
		static bool[] sauceChoices = new bool[count];
		static decimal saucePrice = 0.00m;

		// Cheese options
		//static string cheeseChocies;
		static bool[] cheese = new bool[count];
		static string[] cheeseChoices = { "Regular", "Extra" };
		static decimal cheesePrice = 0.00m;

		// Delivery options
		//static string[] delivery = { "Take out", "Delivery" };
		static bool[] delivery = new bool[count];
		static string[] deliveryOptions = { "Take out", "Delivery" };
		static decimal deliveryPrice = 0.00m;

		// Display option
		static int displayCount = 3;
		static bool[] displaySize = new bool[displayCount];
	

		// Total price
		static decimal totalPrice = 0.00m;
		static string pizzaChoice = null;
	}
}
