using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// this is where your data for your creatures in programming assignment 2
namespace Itse1430.MovieLib
{
    public class Movie
    {
        // in classes we don't want to use fields(variable) we want to use methods(functions) to validate and store data
        public string Name                  // sample on properties
        {                                                                                       // lab 2 ****************************************
            get { return _name; }       // string get ()
            set { _name = value; }      // void set (string value)
        }
        private string _name = "";   // initializer expression     // make it private to protect


        // no longer need this code code because of propteries from above if you have to get value and set value use a property

        //public string GetName()
        //{
        //                                    // know we dont have to deal with null ?? "";
        //    return _name ?? "";            // this is so the user doesnot have access to the field
        //}
        //public void SetName( string value)      // this will be useing in MovieForm.cs to get the data *********************************
        //{
        //    _name = value;
        //}


        //public System.String Name;

        public string Description                   // comon standard for string property
        {
            get { return _description ?? ""; }          // semi colon  goes inside with the statment
            set { _description = value; }
        }
        private string _description;

        //public string GetDescription()
        //{
        //    return _description ?? "";
        //}
        //public void SetDescription( string value)  // nothing special about value just to pass a number or value
        //{
        //    _description = value;                   // _camelCase your fields
        //}

        public int ReleaseYear { get; set; } = 1900;        // initializes the backing field for movie release year

        //public int ReleaseYear                  // non string property
        //{
        //    get { return _releaseYear; }
        //    set { if (value >= 1900)
        //        _releaseYear = value;
        //        }
        //}
        //private int _releaseYear = 1900;            // reason for property we don't want expose this field to the user

        //public int GetReleaseYear()
        //{            
        //    return _releaseYear;
        //}
        //public void SetReleaseYear( int value)
        //{
        //    if (value >= 1900)
        //        _releaseYear = value;
        //}

        public int RunLenght { get; set; }      // this is a auto property same as code below

        //private int _runLenght;       // no longer need this field becuase the auto property generates one

        //public int RunLenght
        //{
        //    get { return _runLenght; }
        //    set {if (value >= 0)                     // in lab 2 *********************************************
        //            _runLenght = value;
        //        }
        //}
        //private int _runLenght;

        //public int GetRunLenght()
        //{
        //    return _runLenght;
        //}
        //public void SetRunLenght( int value )
        //{
        //    if (value >= 0)                     // in lab 2 *********************************************
        //        _runLenght = value;
        //}


        //int someValue;              // both of these are private(only accessable in this class Movie type only) private by default
        //private int someValue2;

        //void Foo()
        //{
        //    var x = RunLenght;  // mixing variable and fields together( x is the variable and RunLenght is the field)
        //                            // local variable are camel case and fields are Pacel case 
        //    var isLong = x > 100;
        //    var y = someValue;      // we still have access to someValue because its in the scope of the class

        //}

         // showing miexed accessibility
        public int Id { get; private set; }             // dummy property
                                                        // mixed accessibility
                                                        // 1) only one you can change
                                                        // 2) it will always be more restrictive
                                                        // 3) if return type is private cannot have public for get or set
                                                        // 4) get or set can either private but only one
                                                        // 5) if getter is private and setter is public is used for passwords
       
        public bool IsColor                     // calculated properties ...... will not have a setter
        {
            get { return ReleaseYear > 1940; }  // this property is deterministic
        }
    }
}
