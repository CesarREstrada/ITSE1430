/****************************************************************************
 * Cesar Estrada
 * ITSE 1430
 * Sample implementation
*****************************************************************************/
using System;

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

        private static void PlayWithObjects()
        {
            int hours = 10;
            Int32 hoursFull = 10;
            var areEqual = hours == hoursFull;

            
            var obj1 = "Hello";
            DisplayObject(obj1);


        }

        private static void DisplayObject( object value )
        {
            if (value == null)
                return;

            // approach 1
            if (value is string)
            {
                var str = (string)value;      // just verifies its a string    
                Console.WriteLine(str);
            } else
            {
                var str = value.ToString();
                Console.WriteLine(str);
            };

            // approach 2------- AS operator
            var str2 = value as string;
            if (str2 != null)
                Console.WriteLine(str2);
            else
                Console.WriteLine(value.ToString());

            // approach 3
            var str3 = value as string;
            Console.WriteLine((str3 != null) ? str3.ToString() : value.ToString());

            // approach 4
            var str4 = value as string;
            Console.WriteLine((str4 ?? value).ToString());  // choses one of the two expressions one ?? two

            // approach 5**
            //var str5 = value is string;             // is returns true or false
            if (value is string str5)                  //the variable it creats is only scoped to this if else statment
                Console.WriteLine(str5.ToString());
            else
                Console.WriteLine(value.ToString());

            // approach 6 know as the null conditional ---- protect me from errors
            var str6 = value as string;
            Console.WriteLine(str6.ToString());

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
             Console.WriteLine($"Hello {firstName} {lastName}");         // $ is crital its an interpeted string   string fullName = $"{firstName} {lastName}"
                                                                         // going forward use this type of string(Interpeted string) *****************************************

             // Null vs Empty-------------------------------------------------------------------------------
             string missing = null;      // c++ and c# nulls are not the same.... Null in C# means i have a value                                    
             string empty = "";
             string empty2 = String.Empty;       // predefinded value which its string is empty---- used for langues that dont use strings

            // every expression has a to string

             // checking for empty strings---------------------------------------------------------
             // if (firstName.Length == 0)            
             //if (missing != null && firstName != "")            // returns a boolean result

             if (!String.IsNullOrEmpty(firstName))       // this is the perfered waay ************************************************************
                 Console.WriteLine(firstName);

             // if (firstName.Lenght == 0)
             // if (firstName == " ")
             // if (firstName ==  string.Empty)

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

        private static void PlayWithArrays()    // examples for arrays
        {
            //int count = ReadInt32("How many name? ", 1);        // the 1 gives us a min value to accept for names

            //string[] names = new string[count];         // how to declare and create strings in C#... also names will be the size names.Length(used below)

            //// reads the name(s) from the user
            //for (int index = 0; index < count; ++index)  // ++index works better for performance purposes in C# and C++
            //{
            //    Console.WriteLine("Name? ");
            //    names[index] = Console.ReadLine();          
            //};

            //// foreach makes it read only
            //// displays the name(s)  name will have the next element in the array names.. also dont have to worry about bounds checking 
            //foreach (string name in names) // equivalent to a while loop (this is better because it has built in protection) does the same thing as the for loop
            ////for (int index = 0; index < names.Length; ++index) // every array expression a length (name of array).Length
            //{
            //    //readonly - not allowed
            //    // name = "";
            //    string str = name;
            //    str = "";
            //    // Console.WriteLine(names[index]);
            //    Console.WriteLine(name);
            //};
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
                    case 'A':
                    AddMovie();
                    return true;

                    case 'e':
                    case 'E':
                    EditMovie();
                    return true;

                    case 'd':
                    case 'D':
                    DeleteMovie();
                    return true;

                    case 'v':
                    case 'V':
                    ViewMovies();
                    return true;

                    case 'q':
                    case 'Q':
                    return false;

                    default:
                    Console.WriteLine("Please enter a valid value.");
                    break;
                };
            };
        }

        private static void AddMovie()
        {
            name = ReadString("Enter a name: ", true);
            description = ReadString("Enter a description: ");
            runLength = ReadInt32("Enter a run length (in minutes): ", 0);
        }

        private static void EditMovie()
        {
            ViewMovies();

            // var makes the compiler figure out what kind of variable it is(1.only use when delcaring a variable
            //2. intinalizer expression. 3. only in local variables 4. you can not declare multiple vars on 1 line
            // 
            // var(auto) instead of using string
            var newName = ReadString("Enter a name (or press ENTER for default): ", false);  // change true to false or take out the true
            if (!String.IsNullOrEmpty(newName))
                name = newName;

            // var(auto) instead of using string
            string newDescription = ReadString("Enter a description (or press ENTER for default): ");
            if (!String.IsNullOrEmpty(newDescription))
                description = newDescription;

            // var(auto) instead of using int
            int newLength = ReadInt32("Enter a run length (in minutes): ", 0);
            if (newLength > 0)
                runLength = newLength;
        }

        private static void DeleteMovie()
        {
            if (Confirm("Are you sure you want to delete this movie:"))
            {
                // "Delete" the movie
                name = null;
                description = null;
                runLength = 0;
            };
        }

        private static bool Confirm( string message )
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

        private static void ViewMovies()
        {
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("No movies available");
                return;
            };

            Console.WriteLine(name);

            if (!String.IsNullOrEmpty(description))
                Console.WriteLine(description);

            //   Console.WriteLine(runLength);
            Console.WriteLine($"Run Lenght = {runLength} mins");
        }

        // Helper Function for program -- its going to read an int and displays an error if an int is not entered
        private static int ReadInt32( string message, int minValue )
        {
            while (true)
            {
                // you can change string to var
                Console.WriteLine(message);
                string input = Console.ReadLine();


                // change out int to out var
                if (Int32.TryParse(input, out int result))
                {
                    if (result >= minValue)
                        return result;
                };

                Console.WriteLine($"You must enter an intger value >= {minValue}");
            };
        }

        // helper function for program
        private static string ReadString( string message )
        {
            return ReadString(message, false);    // this call the readstring bellow        
        }

        // helper function for program
        private static string ReadString( string message, bool required )
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input) || !required)
                    return input;

                Console.WriteLine("You must enter a value");
            };
        }

        // A movie
        static string name;
        static string description;
        static int runLength;
        //static DateTime releaseDate;
    }

}
