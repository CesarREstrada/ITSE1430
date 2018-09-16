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
						Console.WriteLine("Please enter a valid value.");
						break;
				};

			};
		}

		private static bool NewOrder()
		{
			while (true)
			{
				Console.WriteLine("Choose the size of your pizza\n");
				Console.WriteLine("\t1. Small  ($5.00)");
				Console.WriteLine("\t2. Medium ($6.25)");
				Console.WriteLine("\t3. Large  ($8.75)");
				Console.WriteLine("\t4. Return to main menu");
				
				string input = Console.ReadLine();
				switch (input[0])
				{
					case '1':
						SmallPizza();
						return true;

					case '2':
						MediumPizza();
						return true;

					case '3':
						LargePizza();
						return true;

					case '4':						
						return true;

					default:
						Console.WriteLine("Please enter a valid value.");
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
			if (String.IsNullOrEmpty(pizzaChoice))
			{
				Console.WriteLine("No order is available to view at this time.");
				return;
			};
		}

		private static bool SmallPizza()
		{
			int count = 4;
			string[] meatChoices = { "Bacon", "Ham", "Pepperoni", "Sausage" };
			while (true)
			{
				
				Console.WriteLine("Select your toppings for your SMALL PIZZA\n");

				
				Console.WriteLine("Meats (each option is $0.75)\n");
				Console.WriteLine("\t1. Bacon");
				Console.WriteLine("\t2. Ham");
				Console.WriteLine("\t3. Pepperoni");
				Console.WriteLine("\t4. Sausage");
				Console.WriteLine("\t5. Done with meat toppings");

				string input = Console.ReadLine();
				// you may not need line above switch
				//int number;
				//Int32.TryParse(input, out number); // this converts to an int 
				//Console.WriteLine($"{number}\n");
				// just experimenting here ^^^^^^^^^^^^^^^^^^^^^^^
				for (int index = 0; index < count; ++index)
				{
					input = meatChoices[index];
					Console.WriteLine(meatChoices[index]);
				};
				switch (input[0])
				{
					case '1':
						//SmallPizza();
						return true;

					case '2':
						return true;

					case '3':
						return true;

					case '4':
						return true;

					case '5':
						return true;

					default:
						Console.WriteLine("Please enter a valid value.");
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

		//private static void meats()
		//{
		//	SmallPizza();
		//}

		int pizzaCount = 4;
		static string pizzaChoice;
		
	}
}
