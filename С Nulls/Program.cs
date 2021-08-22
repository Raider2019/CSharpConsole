using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С_Nulls
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**************** BASIC CONSOLE I/O ********************");
            GetUserData();
            FormatNumericalData();
            Console.WriteLine("**************** System Date Type and KeyWord C# ********************");
            LocalVarDeclarations();
            NewingDataTypes();
            ObjecFunctionally();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFromStrings();
            ParseFromStringsWithTryTypes();
            UseDatesAndTimes();
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.ReadLine();

        }
        static void GetUserData()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Hello {0}. You are {1} years old.", userName, userAge);
            Console.ForegroundColor = prevColor;
        }
        static void FormatNumericalData()
        {
            Console.WriteLine("***** The value 20000 in variant formats: *****");
            Console.WriteLine("c format:{0:c}", 20000);
            Console.WriteLine("d format:{0:d3}", 20000);
            Console.WriteLine("E format:{0:E}", 20000);
            Console.WriteLine("e format:{0:e}", 20000);
            Console.WriteLine("f format:{0:f4}", 20000);
            Console.WriteLine("G format:{0:G}", 20000);
            Console.WriteLine("n format:{0:n}", 20000);
            Console.WriteLine("X format:{0:X}", 20000);
        }
        static void LocalVarDeclarations()
        {
            Console.WriteLine("***** Data Declarations: *****");
            string MyString;
            MyString = "Hachy";
            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;
            int MyInt = default;
            Console.WriteLine("My data: {0},{1},{2},{3},{4},{5}", MyInt, MyString, b1, b2, b3, b4);
            Console.WriteLine();

        }
        static void NewingDataTypes()
        {
            Console.WriteLine("***** Using new to create variables *****");
            bool b = new bool();
            int i = new int();
            double d = new double();
            DateTime dt = new DateTime();
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void ObjecFunctionally()
        {
            Console.WriteLine("***** System.Object Functionality *****");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Eguals(12) = {0}", 12.Equals(12));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("***** Data type Functionality *****");
            Console.WriteLine("Max of int = {0}", int.MaxValue);
            Console.WriteLine("Min of int = {0}", int.MinValue);
            Console.WriteLine("Max of double= {0}", double.MaxValue);
            Console.WriteLine("Min of double = {0}", double.MinValue);
            Console.WriteLine("double.Epsilon = {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity = {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity = {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString = {0}", bool.FalseString);
            Console.WriteLine("bool.FalseString = {0}", bool.TrueString);
            Console.WriteLine();
        }
        static void CharFunctionality()
        {
            Console.WriteLine("***** Char type Functioality: *****");
            char MyChar = '1';
            Console.WriteLine("char.IsDigit('1') = {0}", char.IsDigit(MyChar));
            Console.WriteLine("char.IsLetter('1') = {0}", char.IsLetter(MyChar));
            Console.WriteLine("char.IsLWhiteSpace('Hello There', 5) = {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsLWhiteSpace('Hello There', 6) = {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsLPuntctuation('?') = {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }
        static void ParseFromStrings()
        {
            Console.WriteLine("***** Data type parsing: *****");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}", d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);
            char c = char.Parse("W");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();

        }
        static void ParseFromStringsWithTryTypes()
        {
            Console.WriteLine("***** Data type parsing with TryParse *****");
            if (bool.TryParse("True", out bool b))
            {
                Console.WriteLine("Value of b: {0}", b);
            }
            string value = "Hellows";

            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);
            }
            else
            {
                Console.WriteLine("Failed to conver the input ({0}) to a double", value);
            }
            Console.WriteLine();


        }
        static void UseDatesAndTimes()
        {
            Console.WriteLine("***** Dates and Times");
            DateTime dt = new DateTime(2021, 08, 22);
            Console.WriteLine("The day of {0} is {1} in {2}", dt.Date, dt.DayOfWeek,dt.DayOfYear);
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(1, 10, 0)));

            Console.WriteLine();
        }
       
    }
}
