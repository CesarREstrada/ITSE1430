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
        // in classes we dont want to use fields(variable) we want to use methods(functions) to validate and store data

        public string GetName()
        {
                                            // know we dont have to deal with null ?? "";
            return _name ?? "";            // this is so the user doesnot have access to the field
        }
        public void SetName( string value)      // this will be useing in MovieForm.cs to get the data *********************************
        {
            _name = value;
        }
        private string _name;        // make it private to protect

        //public System.String Name;

        public string GetDescription()
        {
            return _description ?? "";
        }
        public void SetDescription( string value)  // nothing special about value just to pass a number or value
        {
            _description = value;                   // _camelCase your fields
        }
        private string _description;
        
        public int GetReleaseYear()
        {            
            return _releaseYear;
        }
        public void SetReleaseYear( int value)
        {
            if (value >= 1900)
                _releaseYear = value;
        }
        private int _releaseYear;

        public int GetRunLenght()
        {
            return _runLenght;
        }
        public void SetRunLenght( int value )
        {
            if (value >= 0)
                _runLenght = value;
        }
        private int _runLenght;

        int someValue;              // both of these are private(only accessable in this class Movie type only) private by default
        private int someValue2;

        //void Foo()
        //{
        //    var x = RunLenght;  // mixing variable and fields together( x is the variable and RunLenght is the field)
        //                            // local variable are camel case and fields are Pacel case 
        //    var isLong = x > 100;
        //    var y = someValue;      // we still have access to someValue because its in the scope of the class

        //}
    }
}
