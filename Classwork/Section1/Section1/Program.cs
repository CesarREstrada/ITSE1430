using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        static void Main( string[] args )
        {
            bool notQuit;
            do
            {
                notQuit = DisplayMenu();                               //displays the menu indifinitly
            } while (notQuit);                          

           //PlayWithStrings();
        }

        private static void PlayWithStrings()  // examples on using strings also for the first lab on padding columns
        {
           /* string hoursString = "10";

            //From String -------------------------------------------------------------------------------------------------------------------------
            //int hours = Int32.Parse(hoursString);                     //takes the string and gives the int equivalent (Parse)
            //int hours;
            //bool result = Int32.TryParse(hoursString, out hours);    // safer version to use. It returns if it failed. Returns a boolean value
            // it is required for (out) to before the word hours in C# using TryParse
            //bool result = Int32.TryParse(hoursString, out int hours);  // int is a local declartion


            // To String-------------------------------------------------------------------------------------------------------------------------------
            //hoursString = hours.ToString();                 // work on any expression
            //4.75.ToString(); converts double to a string
            //475.ToString(); converts double to a string                   // converts anything these to a string
            //Console.Readline.ToString(); converts double to a string

            string message = "Hello\tworld";
            string filePath = "C:\\Temp\\Test";

            //Verbatim strings   eliminates the need for the extra Slash like the above statements when calling a file
            //string filePath = @ "C:\Temp\Test";

            // Concat adds two string together
            string firstName = "Bob";
            string lastName = "Smith";
            string name = firstName + " " + lastName;

            // string can not be changed once they are set

            //String are immutable - this produces a new string
            //name = "Hello" + name;
            Console.WriteLine("Hello " + name);                         // approach 1
            Console.WriteLine("Hello {0} {1}", firstName, lastName);    // apporach 2 the zero is a replacement just like an array. Called string formatting
            string str = String.Format("Hello {0}", name);              // apporach 3
            Console.WriteLine(str);

            // Approach 4
            Console.WriteLine($"Hello {firstName} {lastName}");         // $ is crital its an interpeted string
                                                                        // going forward use this type of string(Interpeted string) *****************************************
            
            // Null vs Empty-------------------------------------------------------------------------------
            string missing = null;      // c++ and c# nulls are not the same.... Null in C# means i have a value                                    
            string empty = "";
            string empty2 = String.Empty;       // predefinded value which its string is empty---- used for langues that dont use strings

            // checking for empty strings---------------------------------------------------------
            // if (firstName.Length == 0)            
            //if (missing != null && firstName != "")            // returns a boolean result

            if (!String.IsNullOrEmpty(firstName))       // this is the perfered waay ************************************************************
                Console.WriteLine(firstName);

            // Other Stuff -------------------------------------------------------------------
            string upperName = firstName.ToUpper();         // changes to uppercase letters    
            string lowerName = firstName.ToLower();         // changes to lowercase letters

            // Comparison---------------------------------------------------------------------
            bool areEqual = firstName == lastName;
            areEqual = firstName.ToLower() == lastName.ToLower();       // not the best solution. it will not always work
            areEqual = String.Compare(firstName, lastName, true) == 0;    // still case sensitive -- perfered way ******************************************************************

            // fins a letter in a string-------------------------------------------------------------
            bool startsWithA = firstName.StartsWith("A");           // they are case sensitive
            bool endsWithA = firstName.EndsWith("A");
            bool hasA = firstName.IndexOf("A") >= 0;                // finds if there is an "A" somewhere in the string
            string subset = firstName.Substring(4);                 // returns everthing after the 4 character

            // Clean up-------------------------------------------------------------------------
            string cleanMe = firstName.Trim();                  // removes all white space left and right of string----- also TrimStart, TrimEnd  will clean just the left or right
            string makeLonger = firstName.PadLeft(20); //PadRight         // adds white space to align columns of text----- building table or reciptes***********************
            */
                 
        }

        private static bool DisplayMenu()
        {
            while (true)
            { 
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movie");
                Console.WriteLine("V)iew Movies");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A': AddMovie();
                        return true;

                    case 'e':
                    case 'E': EditMovie();
                        return true;

                    case 'd':
                    case 'D': DeleteMovie();
                        return true;

                    case 'v':
                    case 'V': ViewMovies();
                        return true;

                    case 'q':
                    case 'Q':
                        return false;

                    default: Console.WriteLine("Please enter a valid value.");
                        break;
                };
            };
        }
        
        private static void AddMovie()
        {
            Console.WriteLine("Add Movie");
        }

        private static void EditMovie()
        {
            Console.WriteLine("Edit Movie");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("Delete Movie");
        }

        private static void ViewMovies()
        {
            Console.WriteLine("View Movies");
        }

    }
}
