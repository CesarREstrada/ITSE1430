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
				Console.WriteLine("\t1. Small           $5.00");
				Console.WriteLine("\t2. Medium          $6.25");
				Console.WriteLine("\t3. Large           $8.75");
				Console.WriteLine("\t4. Return to main menu");

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':						
						pizzaSize = "Small Pizza";
						pizzaPrice = 5.00m;
						displaySize[0] = true;						
						SmallPizza();
						return true;

					case '2':
						pizzaSize = "Medium Pizza";
						pizzaPrice = 6.25m;
						displaySize[1] = true;						
						MediumPizza();
						return true;

					case '3':					
						pizzaSize = "Large Pizza";
						pizzaPrice = 8.75m;
						displaySize[2] = true;						
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
			Console.WriteLine("If you modify you order it will be deleted!");

			if (Confirm("Are you sure you want to modify your order:"))
			{
				vegTotal = 0;
				meatTotal = 0;
				totalPrice = 0;
				deliveryPrice = 0;
				cheesePrice = 0;
				saucePrice = 0;
				pizzaPrice = 0;
				pizzaSize = null;
				for (int i = 0; i < displayCount; ++i)
				{
					displaySize[i] = false;
				}
				for (int i = 0; i < count; ++i)
				{					
					delivery[i] = false;
					cheese[i] = false;
					sauceChoices[i] = false;
					vegChoices[i] = false;
					meatChoices[i] = false;
				}
				Console.WriteLine("Your order has been deleted!");
				NewOrder();
			};
		}

		private static void DisplayOrder()
		{
			bool flag = false;

			for (int i = 0; i < displayCount; ++i)
			{				
				if (displaySize[i] == true)
				{
					flag = true;
					var receipt = "Your Order\n";
					Console.WriteLine($"\n\n\t{receipt.PadLeft(20)}");
					if (displaySize[0] == true || displaySize[2] == true)
					{
						Console.WriteLine($"\t{pizzaSize} {pizzaPrice,14:C}");
					}
					else
					{
						Console.WriteLine($"\t{pizzaSize} {pizzaPrice,13:C}");
					}

					// take out or delivery
					for (int j = 0; j < count; ++j)
					{
						if (delivery[j] == true)
						{
							Console.WriteLine($"\t{deliveryOptions[j]}{deliveryPrice,18:C}");
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
							Console.WriteLine($"\t   {meats[j].PadRight(10)}{meatPrice,13:c}");
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
							Console.WriteLine($"\t   {vegetables[j].PadRight(12)}{meatPrice,11:c}");
						}
					}

					// Sauces				
					Console.WriteLine("\tSauce");
					for (int j = 0; j < count; ++j)
					{
						if (sauceChoices[j] == true)
						{
							Console.WriteLine($"\t   {sauces[j].PadRight(12)}{saucePrice,11:c}");
						}
					}

					// cheese
					Console.WriteLine("\tCheese");
					for (int j = 0; j < count; ++j)
					{
						if (cheese[j] == true)
						{
							Console.WriteLine($"\t   {cheeseChoices[j].PadRight(12)}{cheesePrice,11:c}");
						}
					}

					//total
					totalPrice = pizzaPrice + meatTotal + vegTotal + saucePrice + cheesePrice + deliveryPrice;
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
			while (true)
			{
				Console.WriteLine($"Toppings for your {pizzaSize}\n");
				if (displaySize[0] == true || displaySize[2] == true)
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,12:C}");
				}
				else
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,11:C}");
				}
				Console.Write($"\tMeat toppings {meatTotal,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (meatChoices[i] == true)
					{
						Console.Write($"  {meats[i]}");
					}
				}

				Console.WriteLine("\n");
				Console.WriteLine("Select your meats toppings or continue to vegetable toppings\n");
				Console.WriteLine("\t1. Bacon           $0.75");
				Console.WriteLine("\t2. Ham             $0.75");
				Console.WriteLine("\t3. Pepperoni       $0.75");
				Console.WriteLine("\t4. Sausage         $0.75");
				Console.WriteLine("\t5. Continue to vegetable toppings");
				if (meatChoices[0] == true)
				{
					Console.WriteLine("\tB. to remove Bacon");
				}
				if (meatChoices[1] == true)
				{
					Console.WriteLine("\tH. to remove Ham");
				}
				if (meatChoices[2] == true)
				{
					Console.WriteLine("\tP. to remove Pepperoni");
				}
				if (meatChoices[3] == true)
				{
					Console.WriteLine("\tS. to remove Sausage");
				}

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);
				
				switch (input[0])
				{

					case '1':
						meatChoices[0] = true;
						meatTotal += meatPrice;
						meat = true;						
						SmallPizza();
						return true;
					
					case '2':						
						meatChoices[1] = true;
						meatTotal += meatPrice;
						meat = true;	
						SmallPizza();
						return true;

					case '3':						
						meatChoices[2] = true;
						meatTotal += meatPrice;
						meat = true;						
						SmallPizza();
						return true;

					case '4':						
						meatChoices[3] = true;
						meatTotal += meatPrice;
						meat = true;						
						SmallPizza();
						return true;

					case '5':
						VegToppings();
						return true;

					case 'b':
					case 'B':					
						meatChoices[0] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 'h':
					case 'H':
						meatChoices[1] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 'p':
					case 'P':
						meatChoices[2] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 's':
					case 'S':
						meatChoices[3] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					default:
						Console.WriteLine("Please enter a valid value\n\n.");
						break;
				};

			}
		}

		private static bool MediumPizza()
		{
			while (true)
			{
				Console.WriteLine($"Toppings for your {pizzaSize}\n");
				if (displaySize[0] == true || displaySize[2] == true)
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,12:C}");
				}
				else
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,11:C}");
				}
				Console.Write($"\tMeat toppings {meatTotal,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (meatChoices[i] == true)
					{
						Console.Write($"  {meats[i]}");
					}
				}

				Console.WriteLine("\n");
				Console.WriteLine("Select your meats toppings or continue to vegetable toppings\n");
				Console.WriteLine("\t1. Bacon           $0.75");
				Console.WriteLine("\t2. Ham             $0.75");
				Console.WriteLine("\t3. Pepperoni       $0.75");
				Console.WriteLine("\t4. Sausage         $0.75");
				Console.WriteLine("\t5. Continue to vegetable toppings");
				if (meatChoices[0] == true)
				{
					Console.WriteLine("\tB. to remove Bacon");
				}
				if (meatChoices[1] == true)
				{
					Console.WriteLine("\tH. to remove Ham");
				}
				if (meatChoices[2] == true)
				{
					Console.WriteLine("\tP. to remove Pepperoni");
				}
				if (meatChoices[3] == true)
				{
					Console.WriteLine("\tS. to remove Sausage");
				}

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{

					case '1':
						meatChoices[0] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '2':
						meatChoices[1] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '3':
						meatChoices[2] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '4':
						meatChoices[3] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '5':
						VegToppings();
						return true;

					case 'b':
					case 'B':
						meatChoices[0] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 'h':
					case 'H':
						meatChoices[1] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 'p':
					case 'P':
						meatChoices[2] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 's':
					case 'S':
						meatChoices[3] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					default:
						Console.WriteLine("Please enter a valid value\n\n.");
						break;
				};

			}

		}

		private static bool LargePizza()
		{
			while (true)
			{
				Console.WriteLine($"Toppings for your {pizzaSize}\n");
				if (displaySize[0] == true || displaySize[2] == true)
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,12:C}");
				}
				else
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,11:C}");
				}
				Console.Write($"\tMeat toppings {meatTotal,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (meatChoices[i] == true)
					{
						Console.Write($"  {meats[i]}");
					}
				}

				Console.WriteLine("\n");
				Console.WriteLine("Select your meats toppings or continue to vegetable toppings\n");
				Console.WriteLine("\t1. Bacon           $0.75");
				Console.WriteLine("\t2. Ham             $0.75");
				Console.WriteLine("\t3. Pepperoni       $0.75");
				Console.WriteLine("\t4. Sausage         $0.75");
				Console.WriteLine("\t5. Continue to vegetable toppings");
				if (meatChoices[0] == true)
				{
					Console.WriteLine("\tB. to remove Bacon");
				}
				if (meatChoices[1] == true)
				{
					Console.WriteLine("\tH. to remove Ham");
				}
				if (meatChoices[2] == true)
				{
					Console.WriteLine("\tP. to remove Pepperoni");
				}
				if (meatChoices[3] == true)
				{
					Console.WriteLine("\tS. to remove Sausage");
				}

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{

					case '1':
						meatChoices[0] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '2':
						meatChoices[1] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '3':
						meatChoices[2] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '4':
						meatChoices[3] = true;
						meatTotal += meatPrice;
						meat = true;
						SmallPizza();
						return true;

					case '5':
						VegToppings();
						return true;

					case 'b':
					case 'B':
						meatChoices[0] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 'h':
					case 'H':
						meatChoices[1] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 'p':
					case 'P':
						meatChoices[2] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					case 's':
					case 'S':
						meatChoices[3] = false;
						meatTotal -= meatPrice;
						SmallPizza();
						return true;

					default:
						Console.WriteLine("Please enter a valid value\n\n.");
						break;
				};

			}
		}

		private static bool VegToppings()
		{

			while (true)
			{
				Console.WriteLine($"Toppings for your {pizzaSize}\n");
				if (displaySize[0] == true || displaySize[2] == true)
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,12:C}");
				}
				else
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,11:C}");
				}
				Console.Write($"\tMeat toppings {meatTotal,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (meatChoices[i] == true)
					{
						Console.Write($"  {meats[i]}");
					}
				}
				Console.Write("\n");
				Console.Write($"\tVegetable toppings {vegTotal,4:C}");
				for (int i = 0; i < count; ++i)
				{
					if (vegChoices[i] == true)
					{
						Console.Write($"  {vegetables[i]}");
					}
				}

				Console.WriteLine("\n");
				Console.WriteLine("Select your vegetable toppings or continue to your sauce choices\n");
				Console.WriteLine("\t1. Black Olives    $0.50");
				Console.WriteLine("\t2. Mushrooms       $0.50");
				Console.WriteLine("\t3. Onions          $0.50");
				Console.WriteLine("\t4. Peppers         $0.50");
				Console.WriteLine("\t5. Continue to sauce choices");
				if (vegChoices[0] == true)
				{
					Console.WriteLine("\tB. to remove Black Olives");
				}
				if (vegChoices[1] == true)
				{
					Console.WriteLine("\tM. to remove Mushrooms");
				}
				if (vegChoices[2] == true)
				{
					Console.WriteLine("\tO. to remove Onions (use the letter 'O'");
				}
				if (vegChoices[3] == true)
				{
					Console.WriteLine("\tP. to remove Peppers");
				}

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':						
						vegChoices[0] = true;
						vegTotal += vegPrice;
						veg = true;						
						VegToppings();
						return true;

					case '2':
						vegChoices[1] = true;
						vegTotal += vegPrice;
						veg = true;						
						VegToppings();
						return true;

					case '3':						
						vegChoices[2] = true;
						vegTotal += vegPrice;
						veg = true;						
						VegToppings();
						return true;

					case '4':
						vegChoices[3] = true;
						vegTotal += vegPrice;
						veg = true;						
						VegToppings();
						return true;

					case '5':
						SauceSelection();
						return true;

					case 'b':
					case 'B':
						vegChoices[0] = false;
						vegTotal -= vegPrice;
						VegToppings();
						return true;

					case 'm':
					case 'M':
						vegChoices[1] = false;
						vegTotal -= vegPrice;
						VegToppings();
						return true;

					case 'o':
					case 'O':
						vegChoices[2] = false;
						vegTotal -= vegPrice;
						VegToppings();
						return true;

					case 'p':
					case 'P':
						vegChoices[3] = false;
						vegTotal -= vegPrice;
						VegToppings();
						return true;

					default:
						Console.WriteLine("Please enter a valid value");
						break;
				};
			}
		}

		private static bool SauceSelection()
		{

			while (true)
			{
				Console.WriteLine($"Toppings for your {pizzaSize}\n");
				if (displaySize[0] == true || displaySize[2] == true)
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,12:C}");
				}
				else
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,11:C}");
				}
				Console.Write($"\tMeat toppings {meatTotal,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (meatChoices[i] == true)
					{
						Console.Write($"  {meats[i]}");
					}
				}
				Console.Write("\n");
				Console.Write($"\tVegetable toppings {vegTotal,5:C}");
				for (int i = 0; i < count; ++i)
				{
					if (vegChoices[i] == true)
					{
						Console.Write($"  {vegetables[i]}");
					}
				}
				Console.Write("\n");
				Console.Write($"\tSauce options {saucePrice,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (sauceChoices[i] == true)
					{
						Console.WriteLine($"  {sauces[i]}");
					}
				}
				Console.Write("\n\n");

				Console.WriteLine("Select your sauce (one is required)\n");
				Console.WriteLine("\t1. Traditional     $0.00");
				Console.WriteLine("\t2. Garlic          $1.00");
				Console.WriteLine("\t3. Oregano         $1.00\n");
				
				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				switch (input[0])
				{
					case '1':
						sauceChoices[0] = true;							
						Cheese();
						return true;

					case '2':
						sauceChoices[1] = true;
						saucePrice = 1.00m;						
						Cheese();
						return true;

					case '3':
							sauceChoices[2] = true;
							saucePrice = 1.00m;
						Cheese();
						return true;

					default:
						Console.WriteLine("Please enter a valid value");
						break;
				};

			}
		}
		private static bool Cheese()
		{
			while (true)
			{
				Console.WriteLine($"Toppings for your {pizzaSize}\n");
				if (displaySize[0] == true || displaySize[2] == true)
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,12:C}");
				}
				else
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,11:C}");
				}
				Console.Write($"\tMeat toppings {meatTotal,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (meatChoices[i] == true)
					{
						Console.Write($"  {meats[i]}");
					}
				}
				Console.Write("\n");
				Console.Write($"\tVegetable toppings {vegTotal,5:C}");
				for (int i = 0; i < count; ++i)
				{
					if (vegChoices[i] == true)
					{
						Console.Write($"  {vegetables[i]}");
					}
				}
				Console.Write("\n");
				Console.Write($"\tSauce options {saucePrice,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (sauceChoices[i] == true)
					{
						Console.WriteLine($"  {sauces[i]}");
					}
				}
				Console.Write($"\tCheese options {cheesePrice,9:C}");
				for (int i = 0; i < count; ++i)
				{
					if (cheese[i] == true)
					{
						Console.WriteLine($"  {cheeseChoices[i]}");
					}
				}
				Console.Write("\n\n");

				Console.WriteLine("Select your cheese (one is required)\n");
				Console.WriteLine("\t1. Regular         $0.00");
				Console.WriteLine("\t2. Extra           $1.00");
				
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
						Console.WriteLine("Please enter a valid value");
						break;
				};
			}
		}

		private static bool Delivery()
		{
			while (true)
			{
				Console.WriteLine($"Toppings for your {pizzaSize}\n");
				if (displaySize[0] == true || displaySize[2] == true)
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,12:C}");
				}
				else
				{
					Console.WriteLine($"\t{pizzaSize} {pizzaPrice,11:C}");
				}
				Console.Write($"\tMeat toppings {meatTotal,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (meatChoices[i] == true)
					{
						Console.Write($"  {meats[i]}");
					}
				}
				Console.Write("\n");
				Console.Write($"\tVegetable toppings {vegTotal,5:C}");
				for (int i = 0; i < count; ++i)
				{
					if (vegChoices[i] == true)
					{
						Console.Write($"  {vegetables[i]}");
					}
				}
				Console.Write("\n");
				Console.Write($"\tSauce options {saucePrice,10:C}");
				for (int i = 0; i < count; ++i)
				{
					if (sauceChoices[i] == true)
					{
						Console.WriteLine($"  {sauces[i]}");
					}
				}
				Console.Write($"\tCheese options {cheesePrice,9:C}");
				for (int i = 0; i < count; ++i)
				{
					if (cheese[i] == true)
					{
						Console.WriteLine($"  {cheeseChoices[i]}");
					}
				}
				Console.Write("\n");

				Console.WriteLine("Select your Delivery option (one is required)\n");
				Console.WriteLine("\t1. Take out        $0.00");
				Console.WriteLine("\t2. Delivery        $2.50");



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

		private static bool Confirm(string message)
		{			
			Console.WriteLine($"{message} (Y/N)\n");

			do
			{
				ConsoleKeyInfo key = Console.ReadKey(true); // this will just hold the menu until correct key is pressed while not showing what you are entering
				switch (key.KeyChar)
				{
					case 'Y':
					case 'y':
						return true;

					case 'N':
					case 'n':
						return false;
				};
			} while (true); // loops trough if they press in valid charator

			//if (key.KeyChar == 'Y')
			//    return true;
			//else if (key.KeyChar == 'N')
			//    return false;
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
	}
}
