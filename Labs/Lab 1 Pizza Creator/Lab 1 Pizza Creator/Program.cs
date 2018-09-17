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
			string[] pizzaSizes = { "Small Pizza", "Medium", "Large" };
			double[] pizzaPrices = { 5.00, 6.25, 8.75 };

			while (true)
			{
				Console.WriteLine("Choose the size of your pizza\n");
				Console.WriteLine("\t1. Small    $5.00");
				Console.WriteLine("\t2. Medium   $6.25");
				Console.WriteLine("\t3. Large    $8.75");
				Console.WriteLine("\t4. Return to main menu");

				string input = Console.ReadLine();

				switch (input[0])
				{
					case '1':
						// test fot pizza price
						Console.WriteLine($"{pizzaSizes[0]} ${pizzaPrices[0]}");
						SmallPizza(meatChoices);
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

		private static string SmallPizza(string[] meats)
		{
			//int count = 4;          // for the loop test
			double meatPrice = 0.75;
			double totalMeats = 0;
			//string[] meatChoices = { "Bacon", "Ham", "Pepperoni", "Sausage" };
			string[] meatChoices = new string[count];


			while (true)
			{
				Console.WriteLine("Toppings for your SMALL PIZZA\n");
				Console.WriteLine("Select your meats toppings\n");
				Console.WriteLine("\t1. Bacon       $0.75");
				Console.WriteLine("\t2. Ham         $0.75");
				Console.WriteLine("\t3. Pepperoni   $0.75");
				Console.WriteLine("\t4. Sausage     $0.75");
				Console.WriteLine("\t5. Continue to vegetable toppings");

				string input = Console.ReadLine();
				int choice;
				bool input2 = Int32.TryParse(input, out choice);

				if (choice == 1)
				{
					meatChoices[0] = "Bacon";
					//totalMeats += meatPrice;
				}
				if (choice == 2)
				{
					meatChoices[1] = "HAM";
				}
				if (choice == 3)
				{
					meatChoices[2] = "Pepperoni";
				}
				if (choice == 4)
				{
					meatChoices[3] = "Sausage";
				}

				Console.WriteLine(meatChoices[0]);
				Console.WriteLine(meatChoices[1]);
				Console.WriteLine(meatChoices[2]);
				Console.WriteLine(meatChoices[3]);

				

				// you may not need line above switch
				//int number;
				//Int32.TryParse(input, out number); // this converts to an int 
				//Console.WriteLine($"{number}\n");
				// just experimenting here ^^^^^^^^^^^^^^^^^^^^^^^

				// just displays the array
				//for (int index = 0; index < count; ++index)
				//{
				//	input = meatChoices[index];
				//	Console.WriteLine(meatChoices[index]);
				//};

				switch (input[0])
				{
					case '1':

						SmallPizza(meatChoices);
						return meatChoices[0];

					case '2':

						SmallPizza(meatChoices);
						return meatChoices[1];

					case '3':

						SmallPizza(meatChoices);
						return meatChoices[2];

					case '4':
						SmallPizza(meatChoices);
						return meatChoices[3];

					case '5':
						VegToppings();
						return meatChoices[4];

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

		private static bool VegToppings()
		{
			double vegsPrices = 0.50;
			double totalVegs = 0;
			string[] vegsChoices = { "Black olives", "Mushrooms", "Onions", "Peppers" };

			while (true)
			{

				Console.WriteLine("Select your vegetable toppings\n");
				Console.WriteLine("\t1. Black Olives   $0.50");
				Console.WriteLine("\t2. Mushrooms      $0.50");
				Console.WriteLine("\t3. Onions         $0.50");
				Console.WriteLine("\t4. Peppers        $0.50");
				Console.WriteLine("\t5. Continue to sauce selection");

				string input = Console.ReadLine();

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
			double sauce = 0;
			string[] sauceChoices = { "Traditional", "Gralic", "Oregano" };

			while (true)
			{

				Console.WriteLine("Select your sauce\n");
				Console.WriteLine("\t1. Traditional   $0.00");
				Console.WriteLine("\t2. Gralic        $1.00");
				Console.WriteLine("\t3. Oregano       $1.00");
				Console.WriteLine("\t4. Continue to cheese options");

				string input = Console.ReadLine();

				switch (input[0])
				{
					case '1':
						return true;

					case '2':
						return true;

					case '3':
						return true;

					case '4':
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
				double cheese = 0;
				string[] cheesechoices = { "Regular", "Extra" };

				Console.WriteLine("Select your cheese\n");
				Console.WriteLine("\t1. Regular   $0.00");
				Console.WriteLine("\t2. Extra     $1.25");
				Console.WriteLine("\t3. Continue to delivery options");

				string input = Console.ReadLine();

				switch (input[0])
				{
					case '1':
						return true;

					case '2':
						return true;

					case '3':
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
				double delivery = 0;
				string[] deliveryChoice = { "Take out", "Delivery" };

				Console.WriteLine("Select your delivery option\n");
				Console.WriteLine("\t1. Take out   $0.00");
				Console.WriteLine("\t2. Delivery   $2.25");
				Console.WriteLine("\t3. Continue to delivery options");

				string input = Console.ReadLine();

				switch (input[0])
				{
					case '1':
						return true;

					case '2':
						return true;

					case '3':

						return true;

					default:
						Console.WriteLine("Please enter a valid value.");
						break;
				};
			}
		}


		static int count = 4;
		static string[] meatChoices = new string[count];






		static string pizzaChoice = null;
	}
}
