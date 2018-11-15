using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// this is where your data for your creatures in programming assignment 2
namespace Itse1430.MovieLib
{
    [Description("A movie.")]
    public class Movie : IValidatableObject        // interface  -- movie implements IvalidatebaleObject
    {
        // in classes we don't want to use fields(variable) we want to use methods(functions) to validate and store data
        [Required(AllowEmptyStrings = false)]             // attribute that is added medadata required stats that name can not be null***************************************
        //[StringLength(100, MinimumLength = 1)]
        public string Name                  // sample on properties
        {                                                                                       // lab 2 ****************************************
            //get { return _name ?? ""; }       // string get ()
            get => _name ?? ""; // ---> expression bodies           lambda ****************************

            //set { _name = value; }      // void set (string value)
            set => _name = value;
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


        // Using auto property with field initializer ****************************************************
        [Range(1900, 2100, ErrorMessage = "Release year must be greater than or equal to 1900.")]          // ints doubles decimals
        //[Required] *********** does nothing with value types(int)
        //[RangeAttribute(1900, 2100), RequiredAttribute()]
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

        [Range(0, Int32.MaxValue, ErrorMessage = "Run length must be >= 0.")]
        public int RunLength { get; set; }      // this is a auto property same as code below

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


        // public bool IsColor = ReleaseYear > 1940; (anyone can change)
        public bool IsColor => ReleaseYear > 1940;  //Lambda(read only property)                   // calculated properties ...... will not have a setter
        //{
        //    //get { return ReleaseYear > 1940; }  // this property is deterministic
        //    get => ReleaseYear > 1940;  // Lambda ****************************************************
        //}

        public bool IsOwned { get; set; }

        public IEnumerable<ValidationResult> Validate( ValidationContext validationContext ) // this is a interface
        {
            // Using iterator syntax instead of List<T>
            //var results = new List<ValidationResult>();

            //if (String.IsNullOrEmpty(Name))
            //    yield return new ValidationResult("Name is required.", new[] { nameof(Name) }); // [] creates a new array         ******* no longer needed because of [RequiredAttribute]*************

            //if (ReleaseYear < 1900)
            //    yield return new ValidationResult("Release year mest be >= 1900", new[] { nameof(ReleaseYear) });         *** no longer needed [RangeAttribute]

            //    if (RunLength < 0)
            //        yield return new ValidationResult("Run length must be >= 0", new[] { nameof(RunLength) });            *** no longer needed [RangeAttribute]

            yield return null;
        }
    }
}
