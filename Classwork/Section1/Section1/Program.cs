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
            //DisplayMenu();
            PlayWithStrings();
        }

        private static void PlayWithStrings()  // examples on using strings
        {
            string hoursString = "10";

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

            //string message = "Hello\tworld";
            //string filePath = "C:\\Temp\\Test";

            //Verbatim strings   eliminates the need for the extra Slash like the above statements when calling a file
            //string filePath = @ "C:\Temp\Test";

            // Concat adds two string together
            string firstName = "Bob";
            string lastName = "Smith";
            string name = firstName + " " + lastName;

            // string can not be changed once they are set
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("A)dd Movie");
            Console.WriteLine("E)dit Movie");
            Console.WriteLine("D)elete Movie");
            Console.WriteLine("V)iew Movies");
            Console.WriteLine("Q)uit");

            string input = Console.ReadLine();
            switch (input[0])
            {
                case 'A': AddMovie(); break;   
                case 'E': EditMovie(); break;
                case 'D': DeleteMovie(); break;
                case 'V': ViewMovies(); break;
                case 'Q': break;

                default: Console.WriteLine("Please enter a valid value."); break;
            };
        }
        
        private static void AddMovie()
        {
            throw new NotImplementedException();
        }

        private static void EditMovie()
        {
            throw new NotImplementedException();
        }

        private static void DeleteMovie()
        {
            throw new NotImplementedException();
        }

        private static void ViewMovies()
        {
            throw new NotImplementedException();
        }

    }
}
