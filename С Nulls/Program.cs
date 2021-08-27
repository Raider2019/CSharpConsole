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
            UseBigInteger();
            DigitSeparators();
            BinaryLiterals();
            Console.WriteLine("**************** Work is Strings Date ********************");
            BasicStringFunctionality();
            SringConcatenations();
            EscapeChars();
            StringEquality();
            StringEqualitySpecifyingCompareRules();
            StringAreImmutable();
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
        static void UseBigInteger()
        {
            Console.WriteLine("***** Use BigInteger *****");
            BigInteger biggy = BigInteger.Parse("999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            Console.WriteLine("Is  biggy an value?: {0}", biggy.IsEven);
            Console.WriteLine("Is biggy  a power of two?: {0}", biggy.IsPowerOfTwo);
            BigInteger realyBig = BigInteger.Multiply(biggy, BigInteger.Parse("888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", realyBig);
            BigInteger reallyBig2 = biggy * realyBig;
            Console.WriteLine("Value of realyBig2  is :{0}", reallyBig2);

        }
       static void DigitSeparators()
        {
            Console.WriteLine("***** Use Digit Separators *****");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);
            Console.WriteLine();

        }
       private static void BinaryLiterals()
        {
            Console.WriteLine("***** USE BINARY LITERALS *****");

            Console.WriteLine("Sixteen: {0}", 0b0001_0000);
            Console.WriteLine("Thirthy two: {0}", 0b0010_0000);
            Console.WriteLine("Sixty four: {0}", 0b0100_0000);
            Console.WriteLine("Sixty four: {0}", 0b0100_0000);
            Console.WriteLine();
        }
        static void BasicStringFunctionality()
        {
            Console.WriteLine("***** Basic String functionality ******");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName Name has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}.", firstName.ToLower());
            Console.WriteLine("firstName contains the Letter a?: {0}.", firstName.Contains("a"));
            Console.WriteLine("firstName after replace: {0}.", firstName.Replace("dy","yu"));
            Console.WriteLine();
        }
        static void SringConcatenations()
        {
            Console.WriteLine("***** String concatenation *****");
            string s1 = "Programing the";
            string s2 = "PsyhoDrill (PTP)";
            string s3 = String.Concat(s1, s2);
         
            Console.WriteLine(s3);
           
            Console.WriteLine(s3.Substring(0,s3.IndexOf("Ps")));
            Console.WriteLine();

        }
        static void EscapeChars()
        {
            Console.WriteLine("***** Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"Hello World\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\\a");
        
            string myLongStrings = @"This is a very
                very
                    very
                        long string";
            Console.WriteLine( myLongStrings);
            Console.WriteLine("All finished.\a");
            Console.WriteLine();
        }
        static void StringEquality()
        {
            Console.WriteLine("***** String equality *****");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("s1 == hello!: {0}", s1 == "hello");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", s1.IndexOf("e"));

        }
        static void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("***** String equality (Case Insensitive: *****");
            string s1 = "Hello!";
            string s2 = "HELLO!";
            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            Console.WriteLine("Default rules: s1 = {0}, s2 = {1}s1.Equals(s2): {2}", s1,s2,s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2,StringComprasion.OrdinalIgnoreCase : {0}",
                s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case Invariant Culture: s1.Equals(s2,StringComprasion.InvariantCultureIgnoreCase : {0}",
                s1.Equals(s2, StringComparison.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Default rules: s1 = {0}, s2 = {1} s1.IndedOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\",StringComprasion.OrdinalIgnoreCase) : {0}",
                s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case Invariant Culture:  s1.IndexOf(\"E\",StringComprasion.InvariantCultureIgnoreCase) : {0}",
               s1.IndexOf("E", StringComparison.InvariantCulture));
            Console.WriteLine();
        }
        static void StringAreImmutable()
        {
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}",s1);
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);
            Console.WriteLine("s1 = {0}", s1);
        }



    }
}
